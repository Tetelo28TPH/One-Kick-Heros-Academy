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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.grpHeroManagement.SuspendLayout();
            this.grpAbilitiesAndReports.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeroAcademy
            // 
            this.lblHeroAcademy.AutoSize = true;
            this.lblHeroAcademy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeroAcademy.Font = new System.Drawing.Font("Castellar", 21.75F);
            this.lblHeroAcademy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeroAcademy.Location = new System.Drawing.Point(86, 25);
            this.lblHeroAcademy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeroAcademy.Name = "lblHeroAcademy";
            this.lblHeroAcademy.Size = new System.Drawing.Size(482, 35);
            this.lblHeroAcademy.TabIndex = 1;
            this.lblHeroAcademy.Text = "ONE KICK HEROES ACADEMY";
            // 
            // lblAcademicDashboard
            // 
            this.lblAcademicDashboard.AutoSize = true;
            this.lblAcademicDashboard.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAcademicDashboard.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.lblAcademicDashboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAcademicDashboard.Location = new System.Drawing.Point(267, 96);
            this.lblAcademicDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcademicDashboard.Name = "lblAcademicDashboard";
            this.lblAcademicDashboard.Size = new System.Drawing.Size(218, 23);
            this.lblAcademicDashboard.TabIndex = 2;
            this.lblAcademicDashboard.Text = "ACADEMY DASHBOARD";
            this.lblAcademicDashboard.Click += new System.EventHandler(this.lblAcademicDashboard_Click);
            // 
            // lblDashboardDescription
            // 
            this.lblDashboardDescription.AutoSize = true;
            this.lblDashboardDescription.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDashboardDescription.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.lblDashboardDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDashboardDescription.Location = new System.Drawing.Point(151, 119);
            this.lblDashboardDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDashboardDescription.Name = "lblDashboardDescription";
            this.lblDashboardDescription.Size = new System.Drawing.Size(495, 23);
            this.lblDashboardDescription.TabIndex = 3;
            this.lblDashboardDescription.Text = "manage students abilities and reports with precision";
            this.lblDashboardDescription.Click += new System.EventHandler(this.lblDashboardDescription_Click);
            // 
            // grpHeroManagement
            // 
            this.grpHeroManagement.Controls.Add(this.btnView);
            this.grpHeroManagement.Controls.Add(this.btnAddHero);
            this.grpHeroManagement.Controls.Add(this.lblHeroManagement);
            this.grpHeroManagement.Location = new System.Drawing.Point(227, 186);
            this.grpHeroManagement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpHeroManagement.Name = "grpHeroManagement";
            this.grpHeroManagement.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpHeroManagement.Size = new System.Drawing.Size(329, 147);
            this.grpHeroManagement.TabIndex = 4;
            this.grpHeroManagement.TabStop = false;
            this.grpHeroManagement.Enter += new System.EventHandler(this.grpHeroManagement_Enter);
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.Navy;
            this.btnView.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnView.ForeColor = System.Drawing.Color.Cyan;
            this.btnView.Location = new System.Drawing.Point(158, 88);
            this.btnView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(125, 35);
            this.btnView.TabIndex = 2;
            this.btnView.Text = "Search Heroes";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnAddHero
            // 
            this.btnAddHero.BackColor = System.Drawing.Color.Navy;
            this.btnAddHero.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnAddHero.ForeColor = System.Drawing.Color.Cyan;
            this.btnAddHero.Location = new System.Drawing.Point(30, 88);
            this.btnAddHero.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddHero.Name = "btnAddHero";
            this.btnAddHero.Size = new System.Drawing.Size(116, 35);
            this.btnAddHero.TabIndex = 1;
            this.btnAddHero.Text = "Add New Hero";
            this.btnAddHero.UseVisualStyleBackColor = false;
            this.btnAddHero.Click += new System.EventHandler(this.btnAddHero_Click);
            // 
            // lblHeroManagement
            // 
            this.lblHeroManagement.AutoSize = true;
            this.lblHeroManagement.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeroManagement.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.lblHeroManagement.ForeColor = System.Drawing.Color.Cyan;
            this.lblHeroManagement.Location = new System.Drawing.Point(74, 25);
            this.lblHeroManagement.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeroManagement.Name = "lblHeroManagement";
            this.lblHeroManagement.Size = new System.Drawing.Size(176, 23);
            this.lblHeroManagement.TabIndex = 0;
            this.lblHeroManagement.Text = "Hero Management";
            this.lblHeroManagement.Click += new System.EventHandler(this.lblHeroManagement_Click);
            // 
            // grpAbilitiesAndReports
            // 
            this.grpAbilitiesAndReports.Controls.Add(this.btnGenerateReport);
            this.grpAbilitiesAndReports.Controls.Add(this.btnEditAbilities);
            this.grpAbilitiesAndReports.Controls.Add(this.lblAbilitiesAndReports);
            this.grpAbilitiesAndReports.Location = new System.Drawing.Point(227, 337);
            this.grpAbilitiesAndReports.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAbilitiesAndReports.Name = "grpAbilitiesAndReports";
            this.grpAbilitiesAndReports.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grpAbilitiesAndReports.Size = new System.Drawing.Size(329, 137);
            this.grpAbilitiesAndReports.TabIndex = 5;
            this.grpAbilitiesAndReports.TabStop = false;
            this.grpAbilitiesAndReports.Enter += new System.EventHandler(this.grpAbilitiesAndReports_Enter);
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.BackColor = System.Drawing.Color.Navy;
            this.btnGenerateReport.Font = new System.Drawing.Font("Rockwell", 10F);
            this.btnGenerateReport.ForeColor = System.Drawing.Color.Cyan;
            this.btnGenerateReport.Location = new System.Drawing.Point(172, 87);
            this.btnGenerateReport.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(125, 35);
            this.btnGenerateReport.TabIndex = 2;
            this.btnGenerateReport.Text = "Generate report";
            this.btnGenerateReport.UseVisualStyleBackColor = false;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // btnEditAbilities
            // 
            this.btnEditAbilities.BackColor = System.Drawing.Color.Navy;
            this.btnEditAbilities.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnEditAbilities.ForeColor = System.Drawing.Color.Cyan;
            this.btnEditAbilities.Location = new System.Drawing.Point(36, 89);
            this.btnEditAbilities.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEditAbilities.Name = "btnEditAbilities";
            this.btnEditAbilities.Size = new System.Drawing.Size(116, 35);
            this.btnEditAbilities.TabIndex = 1;
            this.btnEditAbilities.Text = "Edit Abilities";
            this.btnEditAbilities.UseVisualStyleBackColor = false;
            this.btnEditAbilities.Click += new System.EventHandler(this.btnEditAbilities_Click);
            // 
            // lblAbilitiesAndReports
            // 
            this.lblAbilitiesAndReports.AutoSize = true;
            this.lblAbilitiesAndReports.Font = new System.Drawing.Font("Britannic Bold", 15.75F);
            this.lblAbilitiesAndReports.ForeColor = System.Drawing.Color.Cyan;
            this.lblAbilitiesAndReports.Location = new System.Drawing.Point(64, 25);
            this.lblAbilitiesAndReports.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAbilitiesAndReports.Name = "lblAbilitiesAndReports";
            this.lblAbilitiesAndReports.Size = new System.Drawing.Size(200, 23);
            this.lblAbilitiesAndReports.TabIndex = 0;
            this.lblAbilitiesAndReports.Text = "Abilities and Reports";
            this.lblAbilitiesAndReports.Click += new System.EventHandler(this.lblAbilitiesAndReports_Click);
            // 
            // pbDashboard
            // 
            this.pbDashboard.BackgroundImage = global::One_Kick_Heroes_Academy.Properties.Resources.lockScreenICO;
            this.pbDashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbDashboard.Location = new System.Drawing.Point(28, 10);
            this.pbDashboard.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pbDashboard.Name = "pbDashboard";
            this.pbDashboard.Size = new System.Drawing.Size(54, 55);
            this.pbDashboard.TabIndex = 0;
            this.pbDashboard.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Red;
            this.btnLogout.Font = new System.Drawing.Font("Rockwell", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLogout.Location = new System.Drawing.Point(638, 30);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(86, 27);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.Text = "LOG OUT";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::One_Kick_Heroes_Academy.Properties.Resources._1016;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(736, 497);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(735, 498);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.grpAbilitiesAndReports);
            this.Controls.Add(this.grpHeroManagement);
            this.Controls.Add(this.lblDashboardDescription);
            this.Controls.Add(this.lblAcademicDashboard);
            this.Controls.Add(this.lblHeroAcademy);
            this.Controls.Add(this.pbDashboard);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmDashboard";
            this.Text = "Dashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDashboard_FormClosed);
            this.Load += new System.EventHandler(this.frmDashboard_Load);
            this.grpHeroManagement.ResumeLayout(false);
            this.grpHeroManagement.PerformLayout();
            this.grpAbilitiesAndReports.ResumeLayout(false);
            this.grpAbilitiesAndReports.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbDashboard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}