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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.btnPrint = new System.Windows.Forms.Button();
            this.pcOneKickHeroAcadmy = new System.Windows.Forms.PictureBox();
            this.lblOneKickHeroAcademy = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.grpTotalHeroes.SuspendLayout();
            this.grpAverageAge.SuspendLayout();
            this.grpAverageExamScore.SuspendLayout();
            this.grpHeroesPerRank.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtSummaryReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcOneKickHeroAcadmy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSummaryReport
            // 
            this.lblSummaryReport.AutoSize = true;
            this.lblSummaryReport.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.lblSummaryReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSummaryReport.Location = new System.Drawing.Point(158, 94);
            this.lblSummaryReport.Name = "lblSummaryReport";
            this.lblSummaryReport.Size = new System.Drawing.Size(277, 36);
            this.lblSummaryReport.TabIndex = 0;
            this.lblSummaryReport.Text = "SUMMARY REPORT";
            this.lblSummaryReport.Click += new System.EventHandler(this.lblSummaryReport_Click);
            // 
            // lblSummaryDetails
            // 
            this.lblSummaryDetails.AutoSize = true;
            this.lblSummaryDetails.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.lblSummaryDetails.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSummaryDetails.Location = new System.Drawing.Point(160, 152);
            this.lblSummaryDetails.Name = "lblSummaryDetails";
            this.lblSummaryDetails.Size = new System.Drawing.Size(620, 36);
            this.lblSummaryDetails.TabIndex = 1;
            this.lblSummaryDetails.Text = "An overview of the acadmy\'s hero statistics";
            this.lblSummaryDetails.Click += new System.EventHandler(this.lblSummaryDetails_Click);
            // 
            // grpTotalHeroes
            // 
            this.grpTotalHeroes.Controls.Add(this.lblCalcTotalSuperheroes);
            this.grpTotalHeroes.Controls.Add(this.lblTotalSuperheroes);
            this.grpTotalHeroes.Location = new System.Drawing.Point(166, 226);
            this.grpTotalHeroes.Name = "grpTotalHeroes";
            this.grpTotalHeroes.Size = new System.Drawing.Size(264, 154);
            this.grpTotalHeroes.TabIndex = 2;
            this.grpTotalHeroes.TabStop = false;
            // 
            // lblCalcTotalSuperheroes
            // 
            this.lblCalcTotalSuperheroes.AutoSize = true;
            this.lblCalcTotalSuperheroes.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcTotalSuperheroes.ForeColor = System.Drawing.Color.Aqua;
            this.lblCalcTotalSuperheroes.Location = new System.Drawing.Point(96, 78);
            this.lblCalcTotalSuperheroes.Name = "lblCalcTotalSuperheroes";
            this.lblCalcTotalSuperheroes.Size = new System.Drawing.Size(73, 26);
            this.lblCalcTotalSuperheroes.TabIndex = 1;
            this.lblCalcTotalSuperheroes.Text = "label6";
            this.lblCalcTotalSuperheroes.Click += new System.EventHandler(this.lblCalcTotalSuperheroes_Click);
            // 
            // lblTotalSuperheroes
            // 
            this.lblTotalSuperheroes.AutoSize = true;
            this.lblTotalSuperheroes.Font = new System.Drawing.Font("Britannic Bold", 12.75F);
            this.lblTotalSuperheroes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblTotalSuperheroes.Location = new System.Drawing.Point(24, 23);
            this.lblTotalSuperheroes.Name = "lblTotalSuperheroes";
            this.lblTotalSuperheroes.Size = new System.Drawing.Size(222, 29);
            this.lblTotalSuperheroes.TabIndex = 0;
            this.lblTotalSuperheroes.Text = "Total Superheroes";
            this.lblTotalSuperheroes.Click += new System.EventHandler(this.lblTotalSuperheroes_Click);
            // 
            // grpAverageAge
            // 
            this.grpAverageAge.Controls.Add(this.lblCalcAverageAge);
            this.grpAverageAge.Controls.Add(this.lblAverageAge);
            this.grpAverageAge.Location = new System.Drawing.Point(468, 226);
            this.grpAverageAge.Name = "grpAverageAge";
            this.grpAverageAge.Size = new System.Drawing.Size(232, 154);
            this.grpAverageAge.TabIndex = 3;
            this.grpAverageAge.TabStop = false;
            // 
            // lblCalcAverageAge
            // 
            this.lblCalcAverageAge.AutoSize = true;
            this.lblCalcAverageAge.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcAverageAge.ForeColor = System.Drawing.Color.Aqua;
            this.lblCalcAverageAge.Location = new System.Drawing.Point(78, 78);
            this.lblCalcAverageAge.Name = "lblCalcAverageAge";
            this.lblCalcAverageAge.Size = new System.Drawing.Size(73, 26);
            this.lblCalcAverageAge.TabIndex = 3;
            this.lblCalcAverageAge.Text = "label7";
            this.lblCalcAverageAge.Click += new System.EventHandler(this.lblCalcAverageAge_Click);
            // 
            // lblAverageAge
            // 
            this.lblAverageAge.AutoSize = true;
            this.lblAverageAge.Font = new System.Drawing.Font("Britannic Bold", 12.75F);
            this.lblAverageAge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAverageAge.Location = new System.Drawing.Point(33, 23);
            this.lblAverageAge.Name = "lblAverageAge";
            this.lblAverageAge.Size = new System.Drawing.Size(152, 29);
            this.lblAverageAge.TabIndex = 2;
            this.lblAverageAge.Text = "Average Age";
            this.lblAverageAge.Click += new System.EventHandler(this.lblAverageAge_Click);
            // 
            // grpAverageExamScore
            // 
            this.grpAverageExamScore.Controls.Add(this.lblCalcAverageExamScore);
            this.grpAverageExamScore.Controls.Add(this.lblAverageExamScore);
            this.grpAverageExamScore.Location = new System.Drawing.Point(735, 226);
            this.grpAverageExamScore.Name = "grpAverageExamScore";
            this.grpAverageExamScore.Size = new System.Drawing.Size(285, 154);
            this.grpAverageExamScore.TabIndex = 3;
            this.grpAverageExamScore.TabStop = false;
            // 
            // lblCalcAverageExamScore
            // 
            this.lblCalcAverageExamScore.AutoSize = true;
            this.lblCalcAverageExamScore.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalcAverageExamScore.ForeColor = System.Drawing.Color.Aqua;
            this.lblCalcAverageExamScore.Location = new System.Drawing.Point(102, 85);
            this.lblCalcAverageExamScore.Name = "lblCalcAverageExamScore";
            this.lblCalcAverageExamScore.Size = new System.Drawing.Size(73, 26);
            this.lblCalcAverageExamScore.TabIndex = 5;
            this.lblCalcAverageExamScore.Text = "label9";
            this.lblCalcAverageExamScore.Click += new System.EventHandler(this.lblCalcAverageExamScore_Click);
            // 
            // lblAverageExamScore
            // 
            this.lblAverageExamScore.AutoSize = true;
            this.lblAverageExamScore.Font = new System.Drawing.Font("Britannic Bold", 12.75F);
            this.lblAverageExamScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAverageExamScore.Location = new System.Drawing.Point(22, 23);
            this.lblAverageExamScore.Name = "lblAverageExamScore";
            this.lblAverageExamScore.Size = new System.Drawing.Size(245, 29);
            this.lblAverageExamScore.TabIndex = 4;
            this.lblAverageExamScore.Text = "Average Exam Score";
            this.lblAverageExamScore.Click += new System.EventHandler(this.lblAverageExamScore_Click);
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
            this.grpHeroesPerRank.Location = new System.Drawing.Point(164, 388);
            this.grpHeroesPerRank.Name = "grpHeroesPerRank";
            this.grpHeroesPerRank.Size = new System.Drawing.Size(855, 329);
            this.grpHeroesPerRank.TabIndex = 3;
            this.grpHeroesPerRank.TabStop = false;
            // 
            // crtSummaryReport
            // 
            chartArea6.Name = "ChartArea1";
            this.crtSummaryReport.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.crtSummaryReport.Legends.Add(legend6);
            this.crtSummaryReport.Location = new System.Drawing.Point(494, 43);
            this.crtSummaryReport.Name = "crtSummaryReport";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.crtSummaryReport.Series.Add(series6);
            this.crtSummaryReport.Size = new System.Drawing.Size(312, 266);
            this.crtSummaryReport.TabIndex = 15;
            this.crtSummaryReport.Text = "chart1";
            // 
            // lblHeroesPerRank
            // 
            this.lblHeroesPerRank.AutoSize = true;
            this.lblHeroesPerRank.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.lblHeroesPerRank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeroesPerRank.Location = new System.Drawing.Point(24, 32);
            this.lblHeroesPerRank.Name = "lblHeroesPerRank";
            this.lblHeroesPerRank.Size = new System.Drawing.Size(253, 36);
            this.lblHeroesPerRank.TabIndex = 14;
            this.lblHeroesPerRank.Text = "Heroes per Rank";
            this.lblHeroesPerRank.Click += new System.EventHandler(this.lblHeroesPerRank_Click);
            // 
            // lblC_Rank
            // 
            this.lblC_Rank.AutoSize = true;
            this.lblC_Rank.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.lblC_Rank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblC_Rank.Location = new System.Drawing.Point(256, 254);
            this.lblC_Rank.Name = "lblC_Rank";
            this.lblC_Rank.Size = new System.Drawing.Size(114, 36);
            this.lblC_Rank.TabIndex = 13;
            this.lblC_Rank.Text = "C-Rank";
            this.lblC_Rank.Click += new System.EventHandler(this.lblC_Rank_Click);
            // 
            // lblNoC_Rank
            // 
            this.lblNoC_Rank.AutoSize = true;
            this.lblNoC_Rank.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoC_Rank.ForeColor = System.Drawing.Color.Blue;
            this.lblNoC_Rank.Location = new System.Drawing.Point(258, 220);
            this.lblNoC_Rank.Name = "lblNoC_Rank";
            this.lblNoC_Rank.Size = new System.Drawing.Size(87, 26);
            this.lblNoC_Rank.TabIndex = 12;
            this.lblNoC_Rank.Text = "label18";
            this.lblNoC_Rank.Click += new System.EventHandler(this.lblNoC_Rank_Click);
            // 
            // lblA_Rank
            // 
            this.lblA_Rank.AutoSize = true;
            this.lblA_Rank.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.lblA_Rank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblA_Rank.Location = new System.Drawing.Point(256, 149);
            this.lblA_Rank.Name = "lblA_Rank";
            this.lblA_Rank.Size = new System.Drawing.Size(112, 36);
            this.lblA_Rank.TabIndex = 11;
            this.lblA_Rank.Text = "A-Rank";
            this.lblA_Rank.Click += new System.EventHandler(this.lblA_Rank_Click);
            // 
            // lblNoA_Rank
            // 
            this.lblNoA_Rank.AutoSize = true;
            this.lblNoA_Rank.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoA_Rank.ForeColor = System.Drawing.Color.Blue;
            this.lblNoA_Rank.Location = new System.Drawing.Point(256, 111);
            this.lblNoA_Rank.Name = "lblNoA_Rank";
            this.lblNoA_Rank.Size = new System.Drawing.Size(87, 26);
            this.lblNoA_Rank.TabIndex = 10;
            this.lblNoA_Rank.Text = "label16";
            this.lblNoA_Rank.Click += new System.EventHandler(this.lblNoA_Rank_Click);
            // 
            // lblB_Rank
            // 
            this.lblB_Rank.AutoSize = true;
            this.lblB_Rank.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.lblB_Rank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblB_Rank.Location = new System.Drawing.Point(108, 254);
            this.lblB_Rank.Name = "lblB_Rank";
            this.lblB_Rank.Size = new System.Drawing.Size(115, 36);
            this.lblB_Rank.TabIndex = 9;
            this.lblB_Rank.Text = "B-Rank";
            this.lblB_Rank.Click += new System.EventHandler(this.lblB_Rank_Click);
            // 
            // lblNoB_Rank
            // 
            this.lblNoB_Rank.AutoSize = true;
            this.lblNoB_Rank.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoB_Rank.ForeColor = System.Drawing.Color.Blue;
            this.lblNoB_Rank.Location = new System.Drawing.Point(108, 220);
            this.lblNoB_Rank.Name = "lblNoB_Rank";
            this.lblNoB_Rank.Size = new System.Drawing.Size(87, 26);
            this.lblNoB_Rank.TabIndex = 8;
            this.lblNoB_Rank.Text = "label14";
            this.lblNoB_Rank.Click += new System.EventHandler(this.lblNoB_Rank_Click);
            // 
            // lblS_Rank
            // 
            this.lblS_Rank.AutoSize = true;
            this.lblS_Rank.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.lblS_Rank.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblS_Rank.Location = new System.Drawing.Point(108, 149);
            this.lblS_Rank.Name = "lblS_Rank";
            this.lblS_Rank.Size = new System.Drawing.Size(113, 36);
            this.lblS_Rank.TabIndex = 7;
            this.lblS_Rank.Text = "S-Rank";
            this.lblS_Rank.Click += new System.EventHandler(this.lblS_Rank_Click);
            // 
            // lblNoS_Rank
            // 
            this.lblNoS_Rank.AutoSize = true;
            this.lblNoS_Rank.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoS_Rank.ForeColor = System.Drawing.Color.Blue;
            this.lblNoS_Rank.Location = new System.Drawing.Point(110, 111);
            this.lblNoS_Rank.Name = "lblNoS_Rank";
            this.lblNoS_Rank.Size = new System.Drawing.Size(87, 26);
            this.lblNoS_Rank.TabIndex = 6;
            this.lblNoS_Rank.Text = "label12";
            this.lblNoS_Rank.Click += new System.EventHandler(this.lblNoS_Rank_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Navy;
            this.btnPrint.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnPrint.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrint.Location = new System.Drawing.Point(884, 152);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(135, 38);
            this.btnPrint.TabIndex = 7;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pcOneKickHeroAcadmy
            // 
            this.pcOneKickHeroAcadmy.BackgroundImage = global::One_Kick_Heroes_Academy.Properties.Resources.lockScreenICO1;
            this.pcOneKickHeroAcadmy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcOneKickHeroAcadmy.Location = new System.Drawing.Point(70, 40);
            this.pcOneKickHeroAcadmy.Name = "pcOneKickHeroAcadmy";
            this.pcOneKickHeroAcadmy.Size = new System.Drawing.Size(56, 55);
            this.pcOneKickHeroAcadmy.TabIndex = 10;
            this.pcOneKickHeroAcadmy.TabStop = false;
            // 
            // lblOneKickHeroAcademy
            // 
            this.lblOneKickHeroAcademy.AutoSize = true;
            this.lblOneKickHeroAcademy.Font = new System.Drawing.Font("Castellar", 21.75F);
            this.lblOneKickHeroAcademy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOneKickHeroAcademy.Location = new System.Drawing.Point(154, 40);
            this.lblOneKickHeroAcademy.Name = "lblOneKickHeroAcademy";
            this.lblOneKickHeroAcademy.Size = new System.Drawing.Size(685, 53);
            this.lblOneKickHeroAcademy.TabIndex = 11;
            this.lblOneKickHeroAcademy.Text = "ONE KICK HERO ACADEMY";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Red;
            this.btnRefresh.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(551, 723);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(135, 38);
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::One_Kick_Heroes_Academy.Properties.Resources.Add_bg;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1127, 790);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Font = new System.Drawing.Font("Rockwell", 12F);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(946, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 41);
            this.button1.TabIndex = 14;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmSummaryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1126, 777);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblOneKickHeroAcademy);
            this.Controls.Add(this.pcOneKickHeroAcadmy);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.grpHeroesPerRank);
            this.Controls.Add(this.grpAverageExamScore);
            this.Controls.Add(this.grpAverageAge);
            this.Controls.Add(this.grpTotalHeroes);
            this.Controls.Add(this.lblSummaryDetails);
            this.Controls.Add(this.lblSummaryReport);
            this.Controls.Add(this.pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}