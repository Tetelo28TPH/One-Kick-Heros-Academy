namespace One_Kick_Heroes_Academy.Forms
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.lblHeroAcademy = new System.Windows.Forms.Label();
            this.lblAcademicDashboard = new System.Windows.Forms.Label();
            this.lblDashboardDescription = new System.Windows.Forms.Label();
            this.grpHeroManagement = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAddHero = new System.Windows.Forms.Button();
            this.lblHeroManagement = new System.Windows.Forms.Label();
            this.grpAbilitiesAndReports = new System.Windows.Forms.GroupBox();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.btnEditAbilities = new System.Windows.Forms.Button();
            this.lblAbilitiesAndReports = new System.Windows.Forms.Label();
            this.pbDashboard = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.grpHeroManagement.SuspendLayout();
            this.grpAbilitiesAndReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeroAcademy
            // 
            this.lblHeroAcademy.AutoSize = true;
            this.lblHeroAcademy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeroAcademy.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroAcademy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeroAcademy.Location = new System.Drawing.Point(115, 31);
            this.lblHeroAcademy.Name = "lblHeroAcademy";
            this.lblHeroAcademy.Size = new System.Drawing.Size(416, 35);
            this.lblHeroAcademy.TabIndex = 1;
            this.lblHeroAcademy.Text = "ONE KICK HEROES ACADEMY";
            // 
            // lblAcademicDashboard
            // 
            this.lblAcademicDashboard.AutoSize = true;
            this.lblAcademicDashboard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAcademicDashboard.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcademicDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAcademicDashboard.Location = new System.Drawing.Point(549, 156);
            this.lblAcademicDashboard.Name = "lblAcademicDashboard";
            this.lblAcademicDashboard.Size = new System.Drawing.Size(294, 31);
            this.lblAcademicDashboard.TabIndex = 2;
            this.lblAcademicDashboard.Text = "ACADEMY DASHBOARD";
            // 
            // lblDashboardDescription
            // 
            this.lblDashboardDescription.AutoSize = true;
            this.lblDashboardDescription.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDashboardDescription.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashboardDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDashboardDescription.Location = new System.Drawing.Point(435, 201);
            this.lblDashboardDescription.Name = "lblDashboardDescription";
            this.lblDashboardDescription.Size = new System.Drawing.Size(507, 27);
            this.lblDashboardDescription.TabIndex = 3;
            this.lblDashboardDescription.Text = "manage students abilities and reports with precision";
            // 
            // grpHeroManagement
            // 
            this.grpHeroManagement.Controls.Add(this.btnView);
            this.grpHeroManagement.Controls.Add(this.btnAddHero);
            this.grpHeroManagement.Controls.Add(this.lblHeroManagement);
            this.grpHeroManagement.Location = new System.Drawing.Point(278, 275);
            this.grpHeroManagement.Name = "grpHeroManagement";
            this.grpHeroManagement.Size = new System.Drawing.Size(413, 209);
            this.grpHeroManagement.TabIndex = 4;
            this.grpHeroManagement.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnView.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.Color.Cyan;
            this.btnView.Location = new System.Drawing.Point(211, 108);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(167, 43);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "View All Heroes";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAddHero
            // 
            this.btnAddHero.BackColor = System.Drawing.Color.Red;
            this.btnAddHero.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddHero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAddHero.Location = new System.Drawing.Point(40, 108);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(154, 43);
            this.btnAddHero.TabIndex = 1;
            this.btnAddHero.Text = "Add New Hero";
            this.btnAddHero.UseVisualStyleBackColor = false;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // lblHeroManagement
            // 
            this.lblHeroManagement.AutoSize = true;
            this.lblHeroManagement.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeroManagement.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroManagement.ForeColor = System.Drawing.Color.Cyan;
            this.lblHeroManagement.Location = new System.Drawing.Point(99, 31);
            this.lblHeroManagement.Name = "lblHeroManagement";
            this.lblHeroManagement.Size = new System.Drawing.Size(232, 31);
            this.lblHeroManagement.TabIndex = 0;
            this.lblHeroManagement.Text = "Hero Management";
            // 
            // grpAbilitiesAndReports
            // 
            this.grpAbilitiesAndReports.Controls.Add(this.btnGenerateReport);
            this.grpAbilitiesAndReports.Controls.Add(this.btnEditAbilities);
            this.grpAbilitiesAndReports.Controls.Add(this.lblAbilitiesAndReports);
            this.grpAbilitiesAndReports.Location = new System.Drawing.Point(716, 275);
            this.grpAbilitiesAndReports.Name = "grpAbilitiesAndReports";
            this.grpAbilitiesAndReports.Size = new System.Drawing.Size(432, 209);
            this.grpAbilitiesAndReports.TabIndex = 5;
            this.grpAbilitiesAndReports.TabStop = false;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.ForeColor = System.Drawing.Color.Cyan;
            this.btnGenerateReport.Location = new System.Drawing.Point(230, 107);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(177, 45);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnEditAbilities
            // 
            this.btnEditAbilities.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditAbilities.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAbilities.ForeColor = System.Drawing.Color.Cyan;
            this.btnEditAbilities.Location = new System.Drawing.Point(48, 109);
            this.btnEditAbilities.Name = "btnEditAbilities";
            this.btnEditAbilities.Size = new System.Drawing.Size(154, 43);
            this.btnEditAbilities.TabIndex = 1;
            this.btnEditAbilities.Text = "edit abilities";
            this.btnEditAbilities.UseVisualStyleBackColor = false;
            this.btnEditAbilities.Click += new System.EventHandler(this.btnEditAbilities_Click);
            // 
            // lblAbilitiesAndReports
            // 
            this.lblAbilitiesAndReports.AutoSize = true;
            this.lblAbilitiesAndReports.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAbilitiesAndReports.ForeColor = System.Drawing.Color.Cyan;
            this.lblAbilitiesAndReports.Location = new System.Drawing.Point(85, 31);
            this.lblAbilitiesAndReports.Name = "lblAbilitiesAndReports";
            this.lblAbilitiesAndReports.Size = new System.Drawing.Size(255, 31);
            this.lblAbilitiesAndReports.TabIndex = 0;
            this.lblAbilitiesAndReports.Text = "Abilities and Reports";
            // 
            // pbDashboard
            // 
            this.pbDashboard.BackgroundImage = global::One_Kick_Heroes_Academy.Properties.Resources.lockScreenICO;
            this.pbDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDashboard.Location = new System.Drawing.Point(37, 12);
            this.pbDashboard.Name = "pbDashboard";
            this.pbDashboard.Size = new System.Drawing.Size(72, 68);
            this.pbDashboard.TabIndex = 0;
            this.pbDashboard.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Blue;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(1208, 12);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(114, 33);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1355, 613);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpAbilitiesAndReports);
            this.Controls.Add(this.grpHeroManagement);
            this.Controls.Add(this.lblDashboardDescription);
            this.Controls.Add(this.lblAcademicDashboard);
            this.Controls.Add(this.lblHeroAcademy);
            this.Controls.Add(this.pbDashboard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.grpHeroManagement.ResumeLayout(false);
            this.grpHeroManagement.PerformLayout();
            this.grpAbilitiesAndReports.ResumeLayout(false);
            this.grpAbilitiesAndReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbDashboard;
        private System.Windows.Forms.Label lblHeroAcademy;
        private System.Windows.Forms.Label lblAcademicDashboard;
        private System.Windows.Forms.Label lblDashboardDescription;
        private System.Windows.Forms.GroupBox grpHeroManagement;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.Button btnAddHero;
        private System.Windows.Forms.Label lblHeroManagement;
        private System.Windows.Forms.GroupBox grpAbilitiesAndReports;
        private System.Windows.Forms.Button btnEditAbilities;
        private System.Windows.Forms.Label lblAbilitiesAndReports;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.Button btnLogout;
    }
}