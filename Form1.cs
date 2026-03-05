using One_Kick_Heroes_Academy.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using One_Kick_Heroes_Academy.Properties;



namespace One_Kick_Heroes_Academy
{
    public partial class FrmLockScreen : Form
    {
        // filepath for users.txt without a fixed directory (github extensions solution option)
        string usersFile = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "users.txt");

        public FrmLockScreen()
        {
            InitializeComponent();
        }

        private void lblHeroAcademy_Click(object sender, EventArgs e)
        {

        }

        private void edtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            // Retrieve username and password from text boxes without extra spaces
            string username = edtHeroID.Text.Trim();
            string password = edtPassword.Text.Trim();

            // text box empty validation
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.", "Missing Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // exception handling for file reading
            try
            {
                if (!File.Exists(usersFile))
                {
                    MessageBox.Show("User file not found. Please contact the administrator.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var users = File.ReadAllLines(usersFile)
                    .Select(line => line.Split(','))
                    .Where(parts => parts.Length >= 2)
                    .ToDictionary(parts => parts[0].Trim(), parts => parts[1].Trim());

                if (users.ContainsKey(username) && users[username] == password)
                {
                    MessageBox.Show($"Welcome back, {username}!", "Login Successful",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // intellisense optional message box

                    this.Hide();
                    frmDashboard dashboard = new frmDashboard();
                    dashboard.Show();
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.",
                        "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading login file: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void edtHeroID_TextChanged(object sender, EventArgs e)
        {

        }

        private void edtHeroID_Click(object sender, EventArgs e)
        {
            // HeroID TextBox
            edtHeroID.Text= string.Empty;
            edtHeroID.ForeColor = Color.Black;
            edtHeroID.BackColor = Color.White;
          
        }

        private void edtPassword_Click(object sender, EventArgs e)
        {
            // Password TextBox
            edtPassword.Text= string.Empty;
            
            edtPassword.ForeColor = Color.Black;
            edtPassword.BackColor = Color.White;
        }

        private void BtnLogin_MouseHover(object sender, EventArgs e)
        {
            //login button cursor change
            BtnLogin.Cursor = Cursors.Hand;
        }

        private void edtHeroID_MouseHover(object sender, EventArgs e)
        {
            edtPassword.Cursor = Cursors.IBeam;
        }

        private void BtnLogin_MouseEnter(object sender, EventArgs e)
        {
            // interactive button color change enter
            BtnLogin.ForeColor = Color.Black;
        }

        private void BtnLogin_MouseLeave(object sender, EventArgs e)
        {
            // interactive button color change leave
            BtnLogin.ForeColor = Color.White;
        }

        private void grpAccessPrototcol_Enter(object sender, EventArgs e)
        {

        }

        private void FrmLockScreen_Load(object sender, EventArgs e)
        {

        }

        private void FrmLockScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Ensure the application exits when the lock screen form is closed
            Application.Exit();
        }

        private void pbLockScreen_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblAccessDescription_Click(object sender, EventArgs e)
        {

        }

        private void lblAccessProtocol_Click(object sender, EventArgs e)
        {

        }
    }
}
