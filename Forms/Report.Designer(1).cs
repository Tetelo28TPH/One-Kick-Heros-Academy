namespace One_Kick_Heroes_Academy.Forms
{
    partial class frmSummaryReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblSummaryReport = new System.Windows.Forms.Label();
            this.lblSummaryDetails = new System.Windows.Forms.Label();
            this.grpTotalHeroes = new System.Windows.Forms.GroupBox();
            this.lblCalcTotalSuperheroes = new System.Windows.Forms.Label();
            this.lblTotalSuperheroes = new System.Windows.Forms.Label();
            this.grpAverageAge = new System.Windows.Forms.GroupBox();
            this.lblCalcAverageAge = new System.Windows.Forms.Label();
            this.lblAverageAge = new System.Windows.Forms.Label();
            this.grpAverageExamScore = new System.Windows.Forms.GroupBox();
            this.lblCalcAverageExamScore = new System.Windows.Forms.Label();
            this.lblAverageExamScore = new System.Windows.Forms.Label();
            this.grpHeroesPerRank = new System.Windows.Forms.GroupBox();
            this.crtSummaryReport = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lblHeroesPerRank = new System.Windows.Forms.Label();
            this.lblC_Rank = new System.Windows.Forms.Label();
            this.lblNoC_Rank = new System.Windows.Forms.Label();
            this.lblA_Rank = new System.Windows.Forms.Label();
            this.lblNoA_Rank = new System.Windows.Forms.Label();
            this.lblB_Rank = new System.Windows.Forms.Label();
            this.lblNoB_Rank = new System.Windows.Forms.Label();
            this.lblS_Rank = new System.Windows.Forms.Label();
            this.lblNoS_Rank = new System.Windows.Forms.Label();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pcOneKickHeroAcadmy = new System.Windows.Forms.PictureBox();
            this.lblOneKickHeroAcademy = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.grpTotalHeroes.SuspendLayout();
            this.grpAverageAge.SuspendLayout();
            this.grpAverageExamScore.SuspendLayout();
            this.grpHeroesPerRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtSummaryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcOneKickHeroAcadmy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSummaryReport
            // 
            this.lblSummaryReport.AutoSize = true;
            this.lblSummaryReport.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSummaryReport.Location = new System.Drawing.Point(129, 143);
            this.lblSummaryReport.Name = "lblSummaryReport";
            this.lblSummaryReport.Size = new System.Drawing.Size(242, 31);
            this.lblSummaryReport.TabIndex = 0;
            this.lblSummaryReport.Text = "SUMMARY REPORT";
            this.lblSummaryReport.Click += new System.EventHandler(this.lblSummaryReport_Click);
            // 
            // lblSummaryDetails
            // 
            this.lblSummaryDetails.AutoSize = true;
            this.lblSummaryDetails.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSummaryDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSummaryDetails.Location = new System.Drawing.Point(132, 189);
            this.lblSummaryDetails.Name = "lblSummaryDetails";
            this.lblSummaryDetails.Size = new System.Drawing.Size(422, 27);
            this.lblSummaryDetails.TabIndex = 1;
            this.lblSummaryDetails.Text = "An overview of the acadmy\'s hero statistics";
            this.lblSummaryDetails.Click += new System.EventHandler(this.lblSummaryDetails_Click);
            // 
            // grpTotalHeroes
            // 
            this.grpTotalHeroes.Controls.Add(this.lblCalcTotalSuperheroes);
            this.grpTotalHeroes.Controls.Add(this.lblTotalSuperheroes);
            this.grpTotalHeroes.Location = new System.Drawing.Point(137, 249);
            this.grpTotalHeroes.Name = "grpTotalHeroes";
            this.grpTotalHeroes.Size = new System.Drawing.Size(234, 123);
            this.grpTotalHeroes.TabIndex = 2;
            this.grpTotalHeroes.TabStop = false;
            // 
            // lblCalcTotalSuperheroes
            // 
            this.lblCalcTotalSuperheroes.AutoSize = true;
            this.lblCalcTotalSuperheroes.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcTotalSuperheroes.ForeColor = System.Drawing.Color.Aqua;
            this.lblCalcTotalSuperheroes.Location = new System.Drawing.Point(85, 63);
            this.lblCalcTotalSuperheroes.Name = "lblCalcTotalSuperheroes";
            this.lblCalcTotalSuperheroes.Size = new System.Drawing.Size(61, 24);
            this.lblCalcTotalSuperheroes.TabIndex = 1;
            this.lblCalcTotalSuperheroes.Text = "label6";
            // 
            // lblTotalSuperheroes
            // 
            this.lblTotalSuperheroes.AutoSize = true;
            this.lblTotalSuperheroes.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSuperheroes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalSuperheroes.Location = new System.Drawing.Point(21, 18);
            this.lblTotalSuperheroes.Name = "lblTotalSuperheroes";
            this.lblTotalSuperheroes.Size = new System.Drawing.Size(196, 27);
            this.lblTotalSuperheroes.TabIndex = 0;
            this.lblTotalSuperheroes.Text = "Total Superheroes";
            // 
            // grpAverageAge
            // 
            this.grpAverageAge.Controls.Add(this.lblCalcAverageAge);
            this.grpAverageAge.Controls.Add(this.lblAverageAge);
            this.grpAverageAge.Location = new System.Drawing.Point(405, 249);
            this.grpAverageAge.Name = "grpAverageAge";
            this.grpAverageAge.Size = new System.Drawing.Size(207, 123);
            this.grpAverageAge.TabIndex = 3;
            this.grpAverageAge.TabStop = false;
            // 
            // lblCalcAverageAge
            // 
            this.lblCalcAverageAge.AutoSize = true;
            this.lblCalcAverageAge.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcAverageAge.ForeColor = System.Drawing.Color.Aqua;
            this.lblCalcAverageAge.Location = new System.Drawing.Point(69, 63);
            this.lblCalcAverageAge.Name = "lblCalcAverageAge";
            this.lblCalcAverageAge.Size = new System.Drawing.Size(61, 24);
            this.lblCalcAverageAge.TabIndex = 3;
            this.lblCalcAverageAge.Text = "label7";
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageAge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAverageAge.Location = new System.Drawing.Point(30, 18);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(142, 27);
            this.lblAverageAge.TabIndex = 2;
            this.lblAverageAge.Text = "Average Age";
            // 
            // grpAverageExamScore
            // 
            this.grpAverageExamScore.Controls.Add(this.lblCalcAverageExamScore);
            this.grpAverageExamScore.Controls.Add(this.lblAverageExamScore);
            this.grpAverageExamScore.Location = new System.Drawing.Point(642, 249);
            this.grpAverageExamScore.Name = "grpAverageExamScore";
            this.grpAverageExamScore.Size = new System.Drawing.Size(253, 123);
            this.grpAverageExamScore.TabIndex = 3;
            this.grpAverageExamScore.TabStop = false;
            // 
            // lblCalcAverageExamScore
            // 
            this.lblCalcAverageExamScore.AutoSize = true;
            this.lblCalcAverageExamScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcAverageExamScore.ForeColor = System.Drawing.Color.Aqua;
            this.lblCalcAverageExamScore.Location = new System.Drawing.Point(90, 68);
            this.lblCalcAverageExamScore.Name = "lblCalcAverageExamScore";
            this.lblCalcAverageExamScore.Size = new System.Drawing.Size(61, 24);
            this.lblCalcAverageExamScore.TabIndex = 5;
            this.lblCalcAverageExamScore.Text = "label9";
            // 
            // lblAverageExamScore
            // 
            this.lblAverageExamScore.AutoSize = true;
            this.lblAverageExamScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAverageExamScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAverageExamScore.Location = new System.Drawing.Point(20, 18);
            this.lblAverageExamScore.Name = "lblAverageExamScore";
            this.lblAverageExamScore.Size = new System.Drawing.Size(218, 27);
            this.lblAverageExamScore.TabIndex = 4;
            this.lblAverageExamScore.Text = "Average Exam Score";
            // 
            // grpHeroesPerRank
            // 
            this.grpHeroesPerRank.Controls.Add(this.crtSummaryReport);
            this.grpHeroesPerRank.Controls.Add(this.lblHeroesPerRank);
            this.grpHeroesPerRank.Controls.Add(this.lblC_Rank);
            this.grpHeroesPerRank.Controls.Add(this.lblNoC_Rank);
            this.grpHeroesPerRank.Controls.Add(this.lblA_Rank);
            this.grpHeroesPerRank.Controls.Add(this.lblNoA_Rank);
            this.grpHeroesPerRank.Controls.Add(this.lblB_Rank);
            this.grpHeroesPerRank.Controls.Add(this.lblNoB_Rank);
            this.grpHeroesPerRank.Controls.Add(this.lblS_Rank);
            this.grpHeroesPerRank.Controls.Add(this.lblNoS_Rank);
            this.grpHeroesPerRank.Location = new System.Drawing.Point(135, 378);
            this.grpHeroesPerRank.Name = "grpHeroesPerRank";
            this.grpHeroesPerRank.Size = new System.Drawing.Size(760, 263);
            this.grpHeroesPerRank.TabIndex = 3;
            this.grpHeroesPerRank.TabStop = false;
            // 
            // crtSummaryReport
            // 
            chartArea1.Name = "ChartArea1";
            this.crtSummaryReport.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.crtSummaryReport.Legends.Add(legend1);
            this.crtSummaryReport.Location = new System.Drawing.Point(439, 35);
            this.crtSummaryReport.Name = "crtSummaryReport";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.crtSummaryReport.Series.Add(series1);
            this.crtSummaryReport.Size = new System.Drawing.Size(278, 213);
            this.crtSummaryReport.TabIndex = 15;
            this.crtSummaryReport.Text = "chart1";
            // 
            // lblHeroesPerRank
            // 
            this.lblHeroesPerRank.AutoSize = true;
            this.lblHeroesPerRank.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroesPerRank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeroesPerRank.Location = new System.Drawing.Point(21, 26);
            this.lblHeroesPerRank.Name = "lblHeroesPerRank";
            this.lblHeroesPerRank.Size = new System.Drawing.Size(205, 31);
            this.lblHeroesPerRank.TabIndex = 14;
            this.lblHeroesPerRank.Text = "Heroes per Rank";
            // 
            // lblC_Rank
            // 
            this.lblC_Rank.AutoSize = true;
            this.lblC_Rank.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblC_Rank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblC_Rank.Location = new System.Drawing.Point(228, 203);
            this.lblC_Rank.Name = "lblC_Rank";
            this.lblC_Rank.Size = new System.Drawing.Size(85, 27);
            this.lblC_Rank.TabIndex = 13;
            this.lblC_Rank.Text = "C-Rank";
            // 
            // lblNoC_Rank
            // 
            this.lblNoC_Rank.AutoSize = true;
            this.lblNoC_Rank.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoC_Rank.ForeColor = System.Drawing.Color.Blue;
            this.lblNoC_Rank.Location = new System.Drawing.Point(229, 176);
            this.lblNoC_Rank.Name = "lblNoC_Rank";
            this.lblNoC_Rank.Size = new System.Drawing.Size(71, 24);
            this.lblNoC_Rank.TabIndex = 12;
            this.lblNoC_Rank.Text = "label18";
            // 
            // lblA_Rank
            // 
            this.lblA_Rank.AutoSize = true;
            this.lblA_Rank.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblA_Rank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblA_Rank.Location = new System.Drawing.Point(228, 119);
            this.lblA_Rank.Name = "lblA_Rank";
            this.lblA_Rank.Size = new System.Drawing.Size(87, 27);
            this.lblA_Rank.TabIndex = 11;
            this.lblA_Rank.Text = "A-Rank";
            // 
            // lblNoA_Rank
            // 
            this.lblNoA_Rank.AutoSize = true;
            this.lblNoA_Rank.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoA_Rank.ForeColor = System.Drawing.Color.Blue;
            this.lblNoA_Rank.Location = new System.Drawing.Point(228, 88);
            this.lblNoA_Rank.Name = "lblNoA_Rank";
            this.lblNoA_Rank.Size = new System.Drawing.Size(71, 24);
            this.lblNoA_Rank.TabIndex = 10;
            this.lblNoA_Rank.Text = "label16";
            // 
            // lblB_Rank
            // 
            this.lblB_Rank.AutoSize = true;
            this.lblB_Rank.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblB_Rank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblB_Rank.Location = new System.Drawing.Point(96, 203);
            this.lblB_Rank.Name = "lblB_Rank";
            this.lblB_Rank.Size = new System.Drawing.Size(86, 27);
            this.lblB_Rank.TabIndex = 9;
            this.lblB_Rank.Text = "B-Rank";
            // 
            // lblNoB_Rank
            // 
            this.lblNoB_Rank.AutoSize = true;
            this.lblNoB_Rank.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoB_Rank.ForeColor = System.Drawing.Color.Blue;
            this.lblNoB_Rank.Location = new System.Drawing.Point(96, 176);
            this.lblNoB_Rank.Name = "lblNoB_Rank";
            this.lblNoB_Rank.Size = new System.Drawing.Size(71, 24);
            this.lblNoB_Rank.TabIndex = 8;
            this.lblNoB_Rank.Text = "label14";
            // 
            // lblS_Rank
            // 
            this.lblS_Rank.AutoSize = true;
            this.lblS_Rank.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblS_Rank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblS_Rank.Location = new System.Drawing.Point(96, 119);
            this.lblS_Rank.Name = "lblS_Rank";
            this.lblS_Rank.Size = new System.Drawing.Size(84, 27);
            this.lblS_Rank.TabIndex = 7;
            this.lblS_Rank.Text = "S-Rank";
            // 
            // lblNoS_Rank
            // 
            this.lblNoS_Rank.AutoSize = true;
            this.lblNoS_Rank.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoS_Rank.ForeColor = System.Drawing.Color.Blue;
            this.lblNoS_Rank.Location = new System.Drawing.Point(97, 88);
            this.lblNoS_Rank.Name = "lblNoS_Rank";
            this.lblNoS_Rank.Size = new System.Drawing.Size(71, 24);
            this.lblNoS_Rank.TabIndex = 6;
            this.lblNoS_Rank.Text = "label12";
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.Color.Blue;
            this.btnGenerate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGenerate.Location = new System.Drawing.Point(1215, 618);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(75, 23);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Blue;
            this.btnPrint.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrint.Location = new System.Drawing.Point(775, 189);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(120, 31);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pcOneKickHeroAcadmy
            // 
            this.pcOneKickHeroAcadmy.BackgroundImage = global::One_Kick_Heroes_Academy.Properties.Resources.lockScreenICO1;
            this.pcOneKickHeroAcadmy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcOneKickHeroAcadmy.Location = new System.Drawing.Point(63, 32);
            this.pcOneKickHeroAcadmy.Name = "pcOneKickHeroAcadmy";
            this.pcOneKickHeroAcadmy.Size = new System.Drawing.Size(49, 44);
            this.pcOneKickHeroAcadmy.TabIndex = 10;
            this.pcOneKickHeroAcadmy.TabStop = false;
            // 
            // lblOneKickHeroAcademy
            // 
            this.lblOneKickHeroAcademy.AutoSize = true;
            this.lblOneKickHeroAcademy.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneKickHeroAcademy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOneKickHeroAcademy.Location = new System.Drawing.Point(137, 32);
            this.lblOneKickHeroAcademy.Name = "lblOneKickHeroAcademy";
            this.lblOneKickHeroAcademy.Size = new System.Drawing.Size(384, 35);
            this.lblOneKickHeroAcademy.TabIndex = 11;
            this.lblOneKickHeroAcademy.Text = "ONE KICK HERO ACADEMY";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Red;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(775, 647);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 31);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1004, 726);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblOneKickHeroAcademy);
            this.Controls.Add(this.pcOneKickHeroAcadmy);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grpHeroesPerRank);
            this.Controls.Add(this.grpAverageExamScore);
            this.Controls.Add(this.grpAverageAge);
            this.Controls.Add(this.grpTotalHeroes);
            this.Controls.Add(this.lblSummaryDetails);
            this.Controls.Add(this.lblSummaryReport);
            this.Name = "frmSummaryReport";
            this.Text = "Summary Report";
            this.Load += new System.EventHandler(this.frmSummaryReport_Load);
            this.grpTotalHeroes.ResumeLayout(false);
            this.grpTotalHeroes.PerformLayout();
            this.grpAverageAge.ResumeLayout(false);
            this.grpAverageAge.PerformLayout();
            this.grpAverageExamScore.ResumeLayout(false);
            this.grpAverageExamScore.PerformLayout();
            this.grpHeroesPerRank.ResumeLayout(false);
            this.grpHeroesPerRank.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtSummaryReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcOneKickHeroAcadmy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSummaryReport;
        private System.Windows.Forms.Label lblSummaryDetails;
        private System.Windows.Forms.GroupBox grpTotalHeroes;
        private System.Windows.Forms.GroupBox grpAverageAge;
        private System.Windows.Forms.GroupBox grpAverageExamScore;
        private System.Windows.Forms.GroupBox grpHeroesPerRank;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lblCalcTotalSuperheroes;
        private System.Windows.Forms.Label lblTotalSuperheroes;
        private System.Windows.Forms.Label lblCalcAverageAge;
        private System.Windows.Forms.Label lblAverageAge;
        private System.Windows.Forms.Label lblCalcAverageExamScore;
        private System.Windows.Forms.Label lblAverageExamScore;
        private System.Windows.Forms.Label lblHeroesPerRank;
        private System.Windows.Forms.Label lblC_Rank;
        private System.Windows.Forms.Label lblNoC_Rank;
        private System.Windows.Forms.Label lblA_Rank;
        private System.Windows.Forms.Label lblNoA_Rank;
        private System.Windows.Forms.Label lblB_Rank;
        private System.Windows.Forms.Label lblNoB_Rank;
        private System.Windows.Forms.Label lblS_Rank;
        private System.Windows.Forms.Label lblNoS_Rank;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtSummaryReport;
        private System.Windows.Forms.PictureBox pcOneKickHeroAcadmy;
        private System.Windows.Forms.Label lblOneKickHeroAcademy;
        private System.Windows.Forms.Button btnRefresh;
    }
}