using One_Kick_Heroes_Academy.BusinessLogicLayer;
using One_Kick_Heroes_Academy.DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace One_Kick_Heroes_Academy.Forms
{
    public partial class frmSummaryReport : Form
    {
        public frmSummaryReport()
        {
            InitializeComponent();
        }

        private void lblSummaryReport_Click(object sender, EventArgs e)
        {

        }

        private void lblSummaryDetails_Click(object sender, EventArgs e)
        {

        }

        private void frmSummaryReport_Load(object sender, EventArgs e)
        {
            // Load data and display summary when the form loads
            DataManager.LoadData();
            DisplaySummary();
            DisplayPieChart();
        }

        private void DisplaySummary()
        {
            // list heroes is taken from datamanager
            var heroes = DataManager.Heroes;

            // reset values

            if (heroes.Count == 0)
            {
                lblCalcTotalSuperheroes.Text = "0";
                lblCalcAverageAge.Text = "0";
                lblCalcAverageExamScore.Text = "0";

                
                lblNoC_Rank.Text = "0";
                lblNoA_Rank.Text = "0";
                lblNoB_Rank.Text = "0";
                lblNoS_Rank.Text = "0";
                return;
            }

            // Calculates average
            double avgAge = heroes.Average(h => h.Age);
            double avgScore = heroes.Average(h => h.ExamScore);

            // Displays calculated values
            lblCalcTotalSuperheroes.Text = heroes.Count.ToString();
            lblCalcAverageAge.Text = $"{avgAge:F1}";
            lblCalcAverageExamScore.Text = $"{avgScore:F1}";

            // Count By threat level

            //int finalsWeekCount = heroes.Count(h => h.ThreatLevel.Equals("S", StringComparison.OrdinalIgnoreCase));
            //int midtermMadnessCount = heroes.Count(h => h.ThreatLevel.Equals("", StringComparison.OrdinalIgnoreCase));
            //int groupProjectCount = heroes.Count(h => h.ThreatLevel.Equals("Group Project Gone Wrong", StringComparison.OrdinalIgnoreCase));
            //int popQuizCount = heroes.Count(h => h.ThreatLevel.Equals("Pop Quiz", StringComparison.OrdinalIgnoreCase));

            // display threat level
            FileHandler handler = new FileHandler();
            SummaryReport report = handler.Calculations();


            lblNoS_Rank.Text = report.S_RankCount.ToString();
            lblNoA_Rank.Text = report.A_RankCount.ToString();
            lblNoB_Rank.Text = report.B_RankCount.ToString();
            lblNoC_Rank.Text = report.C_RankCount.ToString();
        }

        private void DisplayPieChart()
        {
            // gets list from Datamanger
            var heroes = DataManager.Heroes;

            // count by each threat level
            var groupCounts = heroes.GroupBy(h => h.ThreatLevel)
                             .Select(g => new { Threat = g.Key, Count = g.Count() })
                             .ToList();

            // clear data
            crtSummaryReport.Series.Clear();
            crtSummaryReport.Titles.Clear();
            crtSummaryReport.ChartAreas.Clear();

            // Titles
            crtSummaryReport.ChartAreas.Add(new ChartArea("Main"));
            crtSummaryReport.Titles.Add("Superheroes by Threat Level");
            Series series = new Series("ThreatLevels")
            {
                ChartType = SeriesChartType.Pie,
                IsValueShownAsLabel = true
            };

            // chart section display
            foreach (var g in groupCounts)
            {
                series.Points.AddXY(g.Threat, g.Count);
            }

            crtSummaryReport.Series.Add(series);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
           
            // Load data into the DataGridView 
            DataManager.LoadData();
            DisplaySummary();
            DisplayPieChart();
         
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            // write to summary.txt
            FileHandler handler = new FileHandler();
            SummaryReport report = handler.Calculations();

            try
            {
                // refresh Data list
                DataManager.LoadData();
                DisplaySummary();


                // filepath for users.txt without a fixed directory (github extensions solution option)
                string filePath = Path.Combine(Application.StartupPath, "summaryreport.txt");

                var heroes = DataManager.Heroes;

                if (heroes.Count == 0)
                {
                    MessageBox.Show("No data available to write to the report.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

               // recalcualte stat data
                double avgAge = heroes.Average(h => h.Age);
                double avgScore = heroes.Average(h => h.ExamScore);

                string S_RankCount = report.S_RankCount.ToString();
                string A_RankCount = report.A_RankCount.ToString();
                string B_RankCount = report.B_RankCount.ToString();
                string C_RankCount = report.C_RankCount.ToString();
               


                // write to file with using method
                using (StreamWriter sw = new StreamWriter(filePath, false))
                {
                    sw.WriteLine("========================================");
                    sw.WriteLine("        SUPERHERO ACADEMY SUMMARY REPORT");
                    sw.WriteLine("========================================");
                    sw.WriteLine($"Date Generated: {DateTime.Now}");
                    sw.WriteLine();
                    sw.WriteLine($"Total Superheroes: {heroes.Count}");
                    sw.WriteLine($"Average Age: {avgAge:F1}");
                    sw.WriteLine($"Average Exam Score: {avgScore:F1}");
                    sw.WriteLine();
                    sw.WriteLine("Threat Level Breakdown:");
                    sw.WriteLine($"  S-Rank:  {S_RankCount}");
                    sw.WriteLine($"  A-Rank:  {A_RankCount}");
                    sw.WriteLine($"  B-Rank:  {B_RankCount}");
                    sw.WriteLine($"  C-Rank:  {C_RankCount}");
                    sw.WriteLine("========================================");
                }
                MessageBox.Show($"Summary report generated successfully!\n\nFile location:\n{filePath}",
                    "Report Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing report: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTotalSuperheroes_Click(object sender, EventArgs e)
        {

        }

        private void lblAverageAge_Click(object sender, EventArgs e)
        {

        }

        private void lblAverageExamScore_Click(object sender, EventArgs e)
        {

        }

        private void lblCalcAverageExamScore_Click(object sender, EventArgs e)
        {

        }

        private void lblCalcAverageAge_Click(object sender, EventArgs e)
        {

        }

        private void lblCalcTotalSuperheroes_Click(object sender, EventArgs e)
        {

        }

        private void lblHeroesPerRank_Click(object sender, EventArgs e)
        {

        }

        private void lblNoS_Rank_Click(object sender, EventArgs e)
        {

        }

        private void lblNoA_Rank_Click(object sender, EventArgs e)
        {

        }

        private void lblS_Rank_Click(object sender, EventArgs e)
        {

        }

        private void lblA_Rank_Click(object sender, EventArgs e)
        {

        }

        private void lblNoB_Rank_Click(object sender, EventArgs e)
        {

        }

        private void lblNoC_Rank_Click(object sender, EventArgs e)
        {

        }

        private void lblB_Rank_Click(object sender, EventArgs e)
        {

        }

        private void lblC_Rank_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
