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

namespace One_Kick_Heroes_Academy.Forms
{
    public partial class frmHeroView : Form
    {
        
        public frmHeroView()
        {
            InitializeComponent();
           
        }

        private void edtHeroSearch_MouseClick(object sender, MouseEventArgs e)
        {
            edtHeroSearch.Clear();
            edtHeroSearch.ForeColor = Color.Black;
            edtHeroSearch.BackColor = Color.White;
        }

        private void btnFilter_MouseHover(object sender, EventArgs e)
        {
            btnFilter.Cursor = Cursors.Hand;
        }

        

        private void frmHeroView_Load(object sender, EventArgs e)
        {
            DataManager.LoadData();
            DataManager.RefreshGrid(dvgViewHeroRecords);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DataManager.LoadData();
            DataManager.RefreshGrid(dvgViewHeroRecords);
        }

        private void btnRefresh_MouseHover(object sender, EventArgs e)
        {
            btnRefresh.Cursor = Cursors.Hand;
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string searchInput = edtHeroSearch.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchInput))
            {
                MessageBox.Show("Please enter a Hero ID to search.");
                DataManager.RefreshGrid(dvgViewHeroRecords);
                return;
            }

            var filtered = DataManager.SearchById(searchInput);

            if (filtered.Count == 0)
            {
                MessageBox.Show($"No hero found with ID '{searchInput}'.", "Search Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            dvgViewHeroRecords.DataSource = filtered;
        }
    }
}
