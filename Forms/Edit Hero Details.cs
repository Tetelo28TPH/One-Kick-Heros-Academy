using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using One_Kick_Heroes_Academy.DataLayer;
using One_Kick_Heroes_Academy.BusinessLogicLayer;

namespace One_Kick_Heroes_Academy.Forms
{
    public partial class frmUpdateHeroes : Form
    {
        // Reference to the currently selected hero
        private SuperHero selectedHero;


        public frmUpdateHeroes()
        {
            InitializeComponent();
            DataManager.LoadData();
            DataManager.RefreshGrid(dvgEditHeroes);
        }

        private void frmUpdateHeroes_Load(object sender, EventArgs e)
        {
            // Load heroes into DataManager and refresh the grid
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

            // vaalidation: Check if hero exists in DataManager
            var heroToUpdate = DataManager.Heroes.FirstOrDefault(h => h.HeroID.Equals(heroId, StringComparison.OrdinalIgnoreCase));
            if (heroToUpdate == null)
            {
                MessageBox.Show("Hero not found in the file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // update SuperHero properties from textboxes
            heroToUpdate.Name = edtHeroName.Text.Trim();
            heroToUpdate.Age = int.TryParse(edtHeroAge.Text.Trim(), out int age) ? age : 0;
            heroToUpdate.SuperPower = edtHeroSuperPower.Text.Trim();
            heroToUpdate.ExamScore = int.TryParse(edtheroExamScore.Text.Trim(), out int score) ? score : 0;

         
            // heroToUpdate.calcThreatLevelAndRank();
               heroToUpdate.Caller(heroToUpdate.ExamScore);

            // save changes to file
            DataManager.SaveData();

            // reload data into the grid
            DataManager.RefreshGrid(dvgEditHeroes);

            MessageBox.Show("Hero updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    $"Are you sure you want to delete {selectedHero.Name} (ID: {selectedHero.HeroID})?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    // Remove hero from DataManager
                    DataManager.Heroes.Remove(selectedHero);

                    // save changes
                    DataManager.SaveData();

                    // refresh grid
                    DataManager.RefreshGrid(dvgEditHeroes);

                    // reset textboxes
                    ClearInputs();

                    MessageBox.Show("Hero deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            // search for hero by ID
            var filtered = DataManager.SearchById(searchInput);

            if (filtered.Count == 0)
            {
                MessageBox.Show($"No hero found with ID '{searchInput}'.", "Search Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // display search results in the grid
            dvgEditHeroes.DataSource = filtered;
        }

        private void dvgEditHeroes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Populate textboxes with selected hero details in case cell is clicked
            if (e.RowIndex >= 0)
            {
                selectedHero = (SuperHero)dvgEditHeroes.Rows[e.RowIndex].DataBoundItem;

                edtHeroID.Text = selectedHero.HeroID;
                edtHeroName.Text = selectedHero.Name;
                edtHeroAge.Text = selectedHero.Age.ToString();
                edtHeroSuperPower.Text = selectedHero.SuperPower;
                edtheroExamScore.Text = selectedHero.ExamScore.ToString();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
           
           //After a superhero is edited, the method handling the rank and threat level calculation needs to be called again
           //but with the new values.

            DataManager.LoadData();
            DataManager.RefreshGrid(dvgEditHeroes);
        }

        private void edtSearchHeroes_Click(object sender, EventArgs e)
        {
            // CLEAR SEARCH TEXTBOX ON CLICK
            edtSearchHeroes.Clear();
            edtSearchHeroes.ForeColor = Color.Black;
            edtSearchHeroes.BackColor = Color.White;
        }

        private void lblOneKickHeroAcademy_Click(object sender, EventArgs e)
        {

        }

        private void dvgEditHeroes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grpEditRecords_Enter(object sender, EventArgs e)
        {

        }

        private void edtSearchHeroes_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSuperheroRecords_Click(object sender, EventArgs e)
        {

        }

        private void lblEditRecords_Click(object sender, EventArgs e)
        {

        }

        private void lblHeroID_Click(object sender, EventArgs e)
        {

        }

        private void lblHeroName_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblHeroAge_Click(object sender, EventArgs e)
        {

        }

        private void lblHeroSuperpower_Click(object sender, EventArgs e)
        {

        }

        private void edtHeroID_Click(object sender, EventArgs e)
        {
            edtHeroID.ForeColor = Color.Black;
            edtHeroID.BackColor = Color.White;
        }

        private void edtHeroName_Click(object sender, EventArgs e)
        {
            edtHeroName.ForeColor = Color.Black;
            edtHeroName.BackColor = Color.White;
        }

        private void edtHeroAge_Click(object sender, EventArgs e)
        {
            edtHeroAge.ForeColor = Color.Black;
            edtHeroAge.BackColor = Color.White;
        }

        private void edtHeroSuperPower_ChangeUICues(object sender, UICuesEventArgs e)
        {

        }

        private void edtHeroSuperPower_Click(object sender, EventArgs e)
        {

            edtHeroSuperPower.ForeColor = Color.Black;
            edtHeroSuperPower.BackColor = Color.White;

        }

        private void edtheroExamScore_Click(object sender, EventArgs e)
        {

            edtheroExamScore.ForeColor = Color.Black;
            edtheroExamScore.BackColor = Color.White;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
