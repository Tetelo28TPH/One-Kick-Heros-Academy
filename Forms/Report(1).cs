using One_Kick_Heroes_Academy.DataLayer;
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
                lblCalcAverageAge.Text = "N/A";
                lblCalcAverageExamScore.Text = "N/A";

                
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
            
            int lowCount = heroes.Count(h => h.ThreatLevel.Equals("Low", StringComparison.OrdinalIgnoreCase));
            int mediumCount = heroes.Count(h => h.ThreatLevel.Equals("Medium", StringComparison.OrdinalIgnoreCase));
            int highCount = heroes.Count(h => h.ThreatLevel.Equals("High", StringComparison.OrdinalIgnoreCase));
            int criticalCount = heroes.Count(h => h.ThreatLevel.Equals("Critical", StringComparison.OrdinalIgnoreCase));

            // display threat level
            lblNoC_Rank.Text = lowCount.ToString();
            lblNoB_Rank.Text = mediumCount.ToString();
            lblNoA_Rank.Text = highCount.ToString();
            lblNoS_Rank.Text = criticalCount.ToString();
        }

        private void DisplayPieChart()
        {
            // gets list from Datamanger
            var heroes = DataManager.Heroes;

            // count by each threat level
            var groupCounts = heroes.GroupBy(h => h.ThreatLevel).Select(g => new { Threat = g.Key, Count = g.Count() }).ToList();

            // clear data
            crtSummaryReport.Series.Clear();
            crtSummaryReport.Titles.Clear();
            crtSummaryReport.ChartAreas.Clear();

            // Titles
            crtSummaryReport.ChartAreas.Add(new ChartArea("Main"));
            crtSummaryReport.Titles.Add("Superheroes by Threat Level");
            // series
            Series series = new Series("ThreatLevels");
            series.ChartType = SeriesChartType.Pie; ;
            series.IsValueShownAsLabel = true;

            //chart section display
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

                int lowCount = heroes.Count(h => h.ThreatLevel.Equals("Low", StringComparison.OrdinalIgnoreCase));
                int mediumCount = heroes.Count(h => h.ThreatLevel.Equals("Medium", StringComparison.OrdinalIgnoreCase));
                int highCount = heroes.Count(h => h.ThreatLevel.Equals("High", StringComparison.OrdinalIgnoreCase));
                int criticalCount = heroes.Count(h => h.ThreatLevel.Equals("Critical", StringComparison.OrdinalIgnoreCase));

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
                    sw.WriteLine($"  Low:      {lowCount}");
                    sw.WriteLine($"  Medium:   {mediumCount}");
                    sw.WriteLine($"  High:     {highCount}");
                    sw.WriteLine($"  Critical: {criticalCount}");
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
    }
}
