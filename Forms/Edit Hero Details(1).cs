using One_Kick_Heroes_Academy.BusinessLogicLayer;
using One_Kick_Heroes_Academy.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace One_Kick_Heroes_Academy.Forms
{
    public partial class frmUpdateHeroes : Form
    {

        // Create a [class -level variable] to hold the selected hero
        private SuperHero selectedHero;

       
        public frmUpdateHeroes()
        {
            InitializeComponent();
           
        }
        private void frmUpdateHeroes_Load(object sender, EventArgs e)
        {
            // Load data into the DataGridView when the form loads
            DataManager.LoadData();
            DataManager.RefreshGrid(dvgEditHeroes);
            dvgEditHeroes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

        }
      
     
        private void edtUpdate_Click(object sender, EventArgs e)
        {
            //UPDATE DATA THROUGH TEXTBOXES

            // validation: Ensure a row is selected
            if (dvgEditHeroes.CurrentRow == null)
            {
                MessageBox.Show("Please select a hero to update.", "No Selection",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // validation: Ensure Hero ID is not empty
            string heroId = edtHeroID.Text.Trim();

            if (string.IsNullOrWhiteSpace(heroId))
            {
                MessageBox.Show("Hero ID cannot be empty.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // vaalidation: Check if hero already exists
            var heroToUpdate = DataManager.Heroes.FirstOrDefault(h => h.HeroID.Equals(heroId, StringComparison.OrdinalIgnoreCase));

            if (heroToUpdate == null)
            {
                MessageBox.Show("Hero not found in the file.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // update SuperHero properties from textboxes
            heroToUpdate.Name = edtHeroName.Text.Trim();
            heroToUpdate.Age = int.TryParse(edtHeroAge.Text.Trim(), out int age) ? age : 0;
            heroToUpdate.ExamScore = double.TryParse(edtheroExamScore.Text.Trim(), out double score) ? score : 0;

           
            heroToUpdate.calcThreatLevelAndRank();
            // save changes back  to file
            DataManager.SaveData();

            // reload data into the data grid view
            DataManager.RefreshGrid(dvgEditHeroes);

            MessageBox.Show("Hero updated successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void edtDelete_Click(object sender, EventArgs e)
        {
           
        }
    
        private void displayHerosLog_Click(object sender, EventArgs e)
        {
            // SEARCH HERO BY ID
            string searchInput = edtSearchHeroes.Text.Trim();

            // validation: Ensure input is not empty
            if (string.IsNullOrWhiteSpace(searchInput))
            {
                MessageBox.Show("Please enter a Hero ID to search.");
                DataManager.RefreshGrid(dvgEditHeroes);
                return;
            }
            // search for hero by ID using data manager method called SearchById
            var filtered = DataManager.SearchById(searchInput);

            if (filtered.Count == 0)
            {
                MessageBox.Show($"No hero found with ID '{searchInput}'.", "Search Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // display search results in the data grid view
            dvgEditHeroes.DataSource = filtered;
        }

        private void dvgEditHeroes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate textboxes with selected hero details incase cell is clicked
            if (e.RowIndex >= 0)
            {
                var selectedHero = (SuperHero)dvgEditHeroes.Rows[e.RowIndex].DataBoundItem;

                edtHeroID.Text = selectedHero.HeroID;
                edtHeroName.Text = selectedHero.Name;
                edtHeroAge.Text = selectedHero.Age.ToString();
                edtheroExamScore.Text = selectedHero.ExamScore.ToString();
            }
        }

        private void frmUpdateHeroes_Load_1(object sender, EventArgs e)
        {
            // Load data into the DataGridView 
            DataManager.LoadData();
            DataManager.RefreshGrid(dvgEditHeroes);
            dvgEditHeroes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            
           
        }

        
        private void edtDelete_Click_1(object sender, EventArgs e)
        {
            // DELETE HERO bUTTON CLICK EVENT

            //  Validation: Ensure a row is selected
            if (dvgEditHeroes.CurrentRow == null)
            {
                MessageBox.Show("Please select a hero to delete.", "No Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm deletion with the user
            if (dvgEditHeroes.CurrentRow.DataBoundItem is SuperHero selectedHero)
            {
                var confirm = MessageBox.Show(
                    $"Are you sure you want to delete {selectedHero.Name} (ID: {selectedHero.HeroID})?","Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Remove hero from list
                    DataManager.Heroes.Remove(selectedHero);

                    // save changes to file
                    DataManager.SaveData();

                    // refresh data grid view
                    DataManager.RefreshGrid(dvgEditHeroes);

                    // reset teh textboxes
                    ClearInputs();

                    MessageBox.Show("Hero deleted successfully!", "Success",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Invalid selection. Please try again.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputs()
        {
            // clear all textboxes method
            edtHeroID.Clear();
            edtHeroName.Clear();
            edtHeroAge.Clear();
            edtSearchHeroes.Clear();
            edtHeroSuperPower.Clear();
            edtheroExamScore.Clear();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            // renamed to btnRefresh
            // REFRESH BUTTON CLICK EVENT
            // allows the data grid view to reload all data from the file
            DataManager.LoadData();
            DataManager.RefreshGrid(dvgEditHeroes);
        }

        private void dvgEditHeroes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dvgEditHeroes_SelectionChanged(object sender, EventArgs e)
        {
            // Update textboxes when selection changes for the different operations on a row
            if (dvgEditHeroes.CurrentRow?.DataBoundItem is SuperHero hero)
            {
                selectedHero = hero;
                edtHeroID.Text = hero.HeroID;
                edtHeroName.Text = hero.Name;
                edtHeroAge.Text = hero.Age.ToString();
                edtHeroSuperPower.Text = hero.SuperPower;
                edtheroExamScore.Text = hero.ExamScore.ToString();
            }
        }

        private void edtSearchHeroes_Click(object sender, EventArgs e)
        {
            // CLEAR SEARCH TEXTBOX ON CLICK
            edtSearchHeroes.Clear();
            edtSearchHeroes.ForeColor = Color.Black;
            edtSearchHeroes.BackColor = Color.White;
        }
    }
}
