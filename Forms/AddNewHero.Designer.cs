namespace One_Kick_Heroes_Academy.Forms
{
    partial class frmAddNewHero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewHero));
            this.grpAddHero = new System.Windows.Forms.GroupBox();
            this.btnSaveSuperhero = new System.Windows.Forms.Button();
            this.edtHeroExamScore = new System.Windows.Forms.TextBox();
            this.lblHeroExamScore = new System.Windows.Forms.Label();
            this.edtHeroAge = new System.Windows.Forms.TextBox();
            this.lblHeroAge = new System.Windows.Forms.Label();
            this.edtHeroSuperPower = new System.Windows.Forms.TextBox();
            this.lblHeroSuperPower = new System.Windows.Forms.Label();
            this.edtHeroName = new System.Windows.Forms.TextBox();
            this.lblHeroName = new System.Windows.Forms.Label();
            this.edtHeroID = new System.Windows.Forms.TextBox();
            this.lblHeroID = new System.Windows.Forms.Label();
            this.lblAddHeroDescription = new System.Windows.Forms.Label();
            this.lblAddNewHero = new System.Windows.Forms.Label();
            this.pbOneKickHeroAcademy = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.grpAddHero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOneKickHeroAcademy)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAddHero
            // 
            this.grpAddHero.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpAddHero.Controls.Add(this.btnSaveSuperhero);
            this.grpAddHero.Controls.Add(this.edtHeroExamScore);
            this.grpAddHero.Controls.Add(this.lblHeroExamScore);
            this.grpAddHero.Controls.Add(this.edtHeroAge);
            this.grpAddHero.Controls.Add(this.lblHeroAge);
            this.grpAddHero.Controls.Add(this.edtHeroSuperPower);
            this.grpAddHero.Controls.Add(this.lblHeroSuperPower);
            this.grpAddHero.Controls.Add(this.edtHeroName);
            this.grpAddHero.Controls.Add(this.lblHeroName);
            this.grpAddHero.Controls.Add(this.edtHeroID);
            this.grpAddHero.Controls.Add(this.lblHeroID);
            this.grpAddHero.Controls.Add(this.lblAddHeroDescription);
            this.grpAddHero.Controls.Add(this.lblAddNewHero);
            this.grpAddHero.Location = new System.Drawing.Point(396, 122);
            this.grpAddHero.Name = "grpAddHero";
            this.grpAddHero.Size = new System.Drawing.Size(732, 586);
            this.grpAddHero.TabIndex = 0;
            this.grpAddHero.TabStop = false;
            this.grpAddHero.Enter += new System.EventHandler(this.grpAddHero_Enter);
            // 
            // btnSaveSuperhero
            // 
            this.btnSaveSuperhero.BackColor = System.Drawing.Color.Red;
            this.btnSaveSuperhero.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnSaveSuperhero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveSuperhero.Location = new System.Drawing.Point(246, 503);
            this.btnSaveSuperhero.Name = "btnSaveSuperhero";
            this.btnSaveSuperhero.Size = new System.Drawing.Size(246, 52);
            this.btnSaveSuperhero.TabIndex = 1;
            this.btnSaveSuperhero.Text = "Save Superhero";
            this.btnSaveSuperhero.UseVisualStyleBackColor = false;
            this.btnSaveSuperhero.Click += new System.EventHandler(this.btnSaveSuperhero_Click);
            this.btnSaveSuperhero.MouseHover += new System.EventHandler(this.btnSaveSuperhero_MouseHover);
            // 
            // edtHeroExamScore
            // 
            this.edtHeroExamScore.BackColor = System.Drawing.SystemColors.GrayText;
            this.edtHeroExamScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHeroExamScore.ForeColor = System.Drawing.SystemColors.Window;
            this.edtHeroExamScore.Location = new System.Drawing.Point(399, 317);
            this.edtHeroExamScore.Name = "edtHeroExamScore";
            this.edtHeroExamScore.Size = new System.Drawing.Size(276, 33);
            this.edtHeroExamScore.TabIndex = 11;
            this.edtHeroExamScore.Text = "e.g.98";
            this.edtHeroExamScore.Click += new System.EventHandler(this.edtHeroExamScore_Click);
            // 
            // lblHeroExamScore
            // 
            this.lblHeroExamScore.AutoSize = true;
            this.lblHeroExamScore.Font = new System.Drawing.Font("Britannic Bold", 10.75F);
            this.lblHeroExamScore.ForeColor = System.Drawing.Color.Aqua;
            this.lblHeroExamScore.Location = new System.Drawing.Point(393, 263);
            this.lblHeroExamScore.Name = "lblHeroExamScore";
            this.lblHeroExamScore.Size = new System.Drawing.Size(258, 25);
            this.lblHeroExamScore.TabIndex = 10;
            this.lblHeroExamScore.Text = "Hero Exam score (0-100)";
            // 
            // edtHeroAge
            // 
            this.edtHeroAge.BackColor = System.Drawing.SystemColors.GrayText;
            this.edtHeroAge.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHeroAge.ForeColor = System.Drawing.SystemColors.Window;
            this.edtHeroAge.Location = new System.Drawing.Point(102, 317);
            this.edtHeroAge.Name = "edtHeroAge";
            this.edtHeroAge.Size = new System.Drawing.Size(235, 33);
            this.edtHeroAge.TabIndex = 9;
            this.edtHeroAge.Text = "e.g. 25";
            this.edtHeroAge.Click += new System.EventHandler(this.edtHeroAge_Click);
            // 
            // lblHeroAge
            // 
            this.lblHeroAge.AutoSize = true;
            this.lblHeroAge.Font = new System.Drawing.Font("Britannic Bold", 10.75F);
            this.lblHeroAge.ForeColor = System.Drawing.Color.Aqua;
            this.lblHeroAge.Location = new System.Drawing.Point(96, 263);
            this.lblHeroAge.Name = "lblHeroAge";
            this.lblHeroAge.Size = new System.Drawing.Size(47, 25);
            this.lblHeroAge.TabIndex = 8;
            this.lblHeroAge.Text = "Age";
            // 
            // edtHeroSuperPower
            // 
            this.edtHeroSuperPower.BackColor = System.Drawing.SystemColors.GrayText;
            this.edtHeroSuperPower.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHeroSuperPower.ForeColor = System.Drawing.SystemColors.Window;
            this.edtHeroSuperPower.Location = new System.Drawing.Point(102, 426);
            this.edtHeroSuperPower.Name = "edtHeroSuperPower";
            this.edtHeroSuperPower.Size = new System.Drawing.Size(574, 33);
            this.edtHeroSuperPower.TabIndex = 7;
            this.edtHeroSuperPower.Text = "e.g. One Punch";
            this.edtHeroSuperPower.Click += new System.EventHandler(this.edtHeroSuperPower_Click);
            this.edtHeroSuperPower.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edtHeroSuperPower_MouseClick);
            // 
            // lblHeroSuperPower
            // 
            this.lblHeroSuperPower.AutoSize = true;
            this.lblHeroSuperPower.Font = new System.Drawing.Font("Britannic Bold", 10.75F);
            this.lblHeroSuperPower.ForeColor = System.Drawing.Color.Aqua;
            this.lblHeroSuperPower.Location = new System.Drawing.Point(96, 389);
            this.lblHeroSuperPower.Name = "lblHeroSuperPower";
            this.lblHeroSuperPower.Size = new System.Drawing.Size(127, 25);
            this.lblHeroSuperPower.TabIndex = 6;
            this.lblHeroSuperPower.Text = "Superpower";
            // 
            // edtHeroName
            // 
            this.edtHeroName.BackColor = System.Drawing.SystemColors.GrayText;
            this.edtHeroName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHeroName.ForeColor = System.Drawing.SystemColors.Window;
            this.edtHeroName.Location = new System.Drawing.Point(399, 186);
            this.edtHeroName.Name = "edtHeroName";
            this.edtHeroName.Size = new System.Drawing.Size(276, 33);
            this.edtHeroName.TabIndex = 5;
            this.edtHeroName.Text = "e.g Saitama";
            this.edtHeroName.Click += new System.EventHandler(this.edtHeroName_Click);
            this.edtHeroName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edtHeroName_MouseClick);
            // 
            // lblHeroName
            // 
            this.lblHeroName.AutoSize = true;
            this.lblHeroName.Font = new System.Drawing.Font("Britannic Bold", 10.75F);
            this.lblHeroName.ForeColor = System.Drawing.Color.Aqua;
            this.lblHeroName.Location = new System.Drawing.Point(393, 140);
            this.lblHeroName.Name = "lblHeroName";
            this.lblHeroName.Size = new System.Drawing.Size(66, 25);
            this.lblHeroName.TabIndex = 4;
            this.lblHeroName.Text = "Name";
            // 
            // edtHeroID
            // 
            this.edtHeroID.BackColor = System.Drawing.SystemColors.GrayText;
            this.edtHeroID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHeroID.ForeColor = System.Drawing.SystemColors.Window;
            this.edtHeroID.Location = new System.Drawing.Point(102, 186);
            this.edtHeroID.Name = "edtHeroID";
            this.edtHeroID.Size = new System.Drawing.Size(235, 33);
            this.edtHeroID.TabIndex = 3;
            this.edtHeroID.Text = "e.g OKK-007";
            this.edtHeroID.Click += new System.EventHandler(this.edtHeroID_Click);
            this.edtHeroID.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edtHeroID_MouseClick);
            // 
            // lblHeroID
            // 
            this.lblHeroID.AutoSize = true;
            this.lblHeroID.Font = new System.Drawing.Font("Britannic Bold", 10.75F);
            this.lblHeroID.ForeColor = System.Drawing.Color.Aqua;
            this.lblHeroID.Location = new System.Drawing.Point(96, 140);
            this.lblHeroID.Name = "lblHeroID";
            this.lblHeroID.Size = new System.Drawing.Size(86, 25);
            this.lblHeroID.TabIndex = 2;
            this.lblHeroID.Text = "Hero ID";
            // 
            // lblAddHeroDescription
            // 
            this.lblAddHeroDescription.AutoSize = true;
            this.lblAddHeroDescription.Font = new System.Drawing.Font("Britannic Bold", 10.75F);
            this.lblAddHeroDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddHeroDescription.Location = new System.Drawing.Point(148, 72);
            this.lblAddHeroDescription.Name = "lblAddHeroDescription";
            this.lblAddHeroDescription.Size = new System.Drawing.Size(439, 25);
            this.lblAddHeroDescription.TabIndex = 1;
            this.lblAddHeroDescription.Text = "Enter operative data to register a new asset";
            // 
            // lblAddNewHero
            // 
            this.lblAddNewHero.AutoSize = true;
            this.lblAddNewHero.Font = new System.Drawing.Font("Britannic Bold", 10.75F);
            this.lblAddNewHero.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddNewHero.Location = new System.Drawing.Point(260, 23);
            this.lblAddNewHero.Name = "lblAddNewHero";
            this.lblAddNewHero.Size = new System.Drawing.Size(162, 25);
            this.lblAddNewHero.TabIndex = 0;
            this.lblAddNewHero.Text = "ADD NEW HERO";
            // 
            // pbOneKickHeroAcademy
            // 
            this.pbOneKickHeroAcademy.BackgroundImage = global::One_Kick_Heroes_Academy.Properties.Resources.lockScreenICO1;
            this.pbOneKickHeroAcademy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbOneKickHeroAcademy.ErrorImage = global::One_Kick_Heroes_Academy.Properties.Resources.lockScreenICO1;
            this.pbOneKickHeroAcademy.InitialImage = global::One_Kick_Heroes_Academy.Properties.Resources.lockScreenICO;
            this.pbOneKickHeroAcademy.Location = new System.Drawing.Point(52, 28);
            this.pbOneKickHeroAcademy.Name = "pbOneKickHeroAcademy";
            this.pbOneKickHeroAcademy.Size = new System.Drawing.Size(73, 49);
            this.pbOneKickHeroAcademy.TabIndex = 1;
            this.pbOneKickHeroAcademy.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Font = new System.Drawing.Font("Castellar", 21.75F);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(154, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(685, 53);
            this.label1.TabIndex = 2;
            this.label1.Text = "ONE KICK HERO ACADEMY";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Navy;
            this.btnBack.Font = new System.Drawing.Font("Rockwell", 12F);
            this.btnBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnBack.Location = new System.Drawing.Point(1236, 739);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(103, 42);
            this.btnBack.TabIndex = 12;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // frmAddNewHero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::One_Kick_Heroes_Academy.Properties.Resources.Add_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1485, 862);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbOneKickHeroAcademy);
            this.Controls.Add(this.grpAddHero);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAddNewHero";
            this.Text = "Add New Hero";
            this.Load += new System.EventHandler(this.frmAddNewHero_Load);
            this.grpAddHero.ResumeLayout(false);
            this.grpAddHero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbOneKickHeroAcademy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAddHero;
        private System.Windows.Forms.TextBox edtHeroExamScore;
        private System.Windows.Forms.Label lblHeroExamScore;
        private System.Windows.Forms.TextBox edtHeroAge;
        private System.Windows.Forms.Label lblHeroAge;
        private System.Windows.Forms.TextBox edtHeroSuperPower;
        private System.Windows.Forms.Label lblHeroSuperPower;
        private System.Windows.Forms.TextBox edtHeroName;
        private System.Windows.Forms.Label lblHeroName;
        private System.Windows.Forms.TextBox edtHeroID;
        private System.Windows.Forms.Label lblHeroID;
        private System.Windows.Forms.Label lblAddHeroDescription;
        private System.Windows.Forms.Label lblAddNewHero;
        private System.Windows.Forms.Button btnSaveSuperhero;
        private System.Windows.Forms.PictureBox pbOneKickHeroAcademy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBack;
    }
}