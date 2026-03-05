using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Kick_Heroes_Academy.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void frmDashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ensure the application exits when the dashboard form is closed
            Application.Exit();
        }

        private void btnAddHero_Click(object sender, EventArgs e)
        {
            // OPEN THE ADD NEW HERO FORM
            frmAddNewHero addNewHero = new frmAddNewHero();
            addNewHero.ShowDialog();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // OPEN THE HERO VIEW FORM
            frmHeroView addHeroView = new frmHeroView();
            addHeroView.ShowDialog();
        }

        private void btnEditAbilities_Click(object sender, EventArgs e)
        {
            // OPEN THE UPDATE HEROES FORM
            frmUpdateHeroes updateHeroes = new frmUpdateHeroes();
            updateHeroes.ShowDialog();
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            // OPEN THE SUMMARY REPORT FORM
            frmSummaryReport report = new frmSummaryReport();   
            report.ShowDialog();
        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            // LOGOUT AND RETURN TO LOGIN SCREEN
            var confirm = MessageBox.Show("Are you sure you want to log out?",
                "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                this.Hide();
                FrmLockScreen login = new FrmLockScreen();
                login.Show();
            }
        }

        private void lblHeroManagement_Click(object sender, EventArgs e)
        {

        }

        private void grpAbilitiesAndReports_Enter(object sender, EventArgs e)
        {

        }

        private void grpHeroManagement_Enter(object sender, EventArgs e)
        {

        }

        private void lblAcademicDashboard_Click(object sender, EventArgs e)
        {

        }

        private void lblDashboardDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblAbilitiesAndReports_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
