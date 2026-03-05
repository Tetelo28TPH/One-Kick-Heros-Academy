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
    public partial class frmAddNewHero : Form
    {
        // Filehandler class variable for file operations
        FileHandler handler = new FileHandler();
        public frmAddNewHero()
        {
            InitializeComponent();
        }

        private void btnSaveSuperhero_Click(object sender, EventArgs e)
        {
            // SAVE NEW HERO 
            try
            {
                // validation checks
                string ID = edtHeroID.Text.Trim();
                if (string.IsNullOrWhiteSpace(ID))
                {
                    MessageBox.Show("Please enter a hero ID.");
                    return;
                }
                string name = edtHeroName.Text.Trim();
                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Please enter a hero name.");
                    return;
                }

                if (DataManager.Heroes.Any(h => h.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
                {
                    MessageBox.Show("A hero with this name already exists!");
                    return;
                }

                if (!int.TryParse(edtHeroAge.Text, out int age))
                {
                    MessageBox.Show("Please enter a valid numeric value for age.");
                    return;
                }

                string superpower = edtHeroSuperPower.Text.Trim();
                if (string.IsNullOrWhiteSpace(superpower))
                {
                    MessageBox.Show("Please enter a hero SuperPower.");
                    return;
                }

                if (!double.TryParse(edtHeroExamScore.Text, out double score))
                {
                    MessageBox.Show("Please enter a valid numeric value for exam score.");
                    return;
                }

                if (score < 0 || score > 100)
                {
                    MessageBox.Show("Exam score must be between 0 and 100.");
                    return;
                }

                // add new superhero object
                var hero = new SuperHero(ID, name, age, superpower, score);
                hero.calcThreatLevelAndRank();

                //  add to list and save to file
                DataManager.Heroes.Add(hero);
                DataManager.SaveData();


                // Clear input fields after successful addition
                ClearInputs();
                MessageBox.Show("Hero added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding hero: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void frmAddNewHero_Load(object sender, EventArgs e)
        {
            // Load existing data when the form loads
            DataManager.LoadData();
        }


        private void ClearInputs()
        {
            // clear all textboxes method
            edtHeroName.Clear();
            edtHeroAge.Clear();
            edtHeroExamScore.Clear();
            edtHeroSuperPower.Clear();
            edtHeroID.Clear();
        }

        private void grpAddHero_Enter(object sender, EventArgs e)
        {

        }

        private void edtHeroID_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void edtHeroName_MouseClick(object sender, MouseEventArgs e)
        {
          
        }
        private void edtHeroAge_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
        private void edtHeroExamScore_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void edtHeroSuperPower_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnSaveSuperhero_MouseHover(object sender, EventArgs e)
        {
            // save button cursor change
            btnSaveSuperhero.Cursor = Cursors.Hand;
        }

        private void edtHeroAge_Click(object sender, EventArgs e)
        {
            // clear age textbox on click
            edtHeroAge.Text = string.Empty;
            edtHeroAge.ForeColor = Color.Black;
            edtHeroAge.BackColor = Color.White;
        }

        private void edtHeroExamScore_Click(object sender, EventArgs e)
        {
            // clear exam score textbox on click
            edtHeroExamScore.Text = string.Empty;
            edtHeroExamScore.ForeColor = Color.Black;
            edtHeroExamScore.BackColor = Color.White;
        }

        private void edtHeroSuperPower_Click(object sender, EventArgs e)
        {
            // clear superpower textbox on click
            edtHeroSuperPower.Text = string.Empty;
            edtHeroSuperPower.ForeColor = Color.Black;
            edtHeroSuperPower.BackColor = Color.White;
        }

        private void edtHeroID_Click(object sender, EventArgs e)
        {
            // clear hero ID textbox on click
            edtHeroID.Text = string.Empty;
            edtHeroID.ForeColor = Color.Black;
            edtHeroID.BackColor = Color.White;
        }

        private void edtHeroName_Click(object sender, EventArgs e)
        {
            // clear hero name textbox on click
            edtHeroName.Text = string.Empty;
            edtHeroName.ForeColor = Color.Black;
            edtHeroName.BackColor = Color.White;
        }
    }
}
