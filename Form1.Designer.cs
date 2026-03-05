namespace One_Kick_Heroes_Academy
{
    partial class FrmLockScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLockScreen));
            this.pbLockScreen = new System.Windows.Forms.PictureBox();
            this.lblHeroAcademy = new System.Windows.Forms.Label();
            this.grpAccessPrototcol = new System.Windows.Forms.GroupBox();
            this.lblAccessProtocol = new System.Windows.Forms.Label();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.edtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.edtHeroID = new System.Windows.Forms.TextBox();
            this.lblHeroID = new System.Windows.Forms.Label();
            this.lblAccessDescription = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbLockScreen)).BeginInit();
            this.grpAccessPrototcol.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbLockScreen
            // 
            this.pbLockScreen.BackgroundImage = global::One_Kick_Heroes_Academy.Properties.Resources.lockScreenICO;
            this.pbLockScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLockScreen.Location = new System.Drawing.Point(65, 34);
            this.pbLockScreen.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbLockScreen.Name = "pbLockScreen";
            this.pbLockScreen.Size = new System.Drawing.Size(47, 40);
            this.pbLockScreen.TabIndex = 0;
            this.pbLockScreen.TabStop = false;
            this.pbLockScreen.Click += new System.EventHandler(this.pbLockScreen_Click);
            // 
            // lblHeroAcademy
            // 
            this.lblHeroAcademy.AutoSize = true;
            this.lblHeroAcademy.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeroAcademy.Font = new System.Drawing.Font("Castellar", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroAcademy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeroAcademy.Location = new System.Drawing.Point(118, 34);
            this.lblHeroAcademy.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeroAcademy.Name = "lblHeroAcademy";
            this.lblHeroAcademy.Size = new System.Drawing.Size(482, 35);
            this.lblHeroAcademy.TabIndex = 1;
            this.lblHeroAcademy.Text = "ONE KICK HEROES ACADEMY";
            this.lblHeroAcademy.Click += new System.EventHandler(this.lblHeroAcademy_Click);
            // 
            // grpAccessPrototcol
            // 
            this.grpAccessPrototcol.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.grpAccessPrototcol.Controls.Add(this.lblAccessProtocol);
            this.grpAccessPrototcol.Controls.Add(this.BtnLogin);
            this.grpAccessPrototcol.Controls.Add(this.edtPassword);
            this.grpAccessPrototcol.Controls.Add(this.lblPassword);
            this.grpAccessPrototcol.Controls.Add(this.edtHeroID);
            this.grpAccessPrototcol.Controls.Add(this.lblHeroID);
            this.grpAccessPrototcol.Controls.Add(this.lblAccessDescription);
            this.grpAccessPrototcol.Location = new System.Drawing.Point(124, 72);
            this.grpAccessPrototcol.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpAccessPrototcol.Name = "grpAccessPrototcol";
            this.grpAccessPrototcol.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.grpAccessPrototcol.Size = new System.Drawing.Size(410, 350);
            this.grpAccessPrototcol.TabIndex = 2;
            this.grpAccessPrototcol.TabStop = false;
            this.grpAccessPrototcol.Enter += new System.EventHandler(this.grpAccessPrototcol_Enter);
            // 
            // lblAccessProtocol
            // 
            this.lblAccessProtocol.AutoSize = true;
            this.lblAccessProtocol.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessProtocol.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblAccessProtocol.Location = new System.Drawing.Point(123, 14);
            this.lblAccessProtocol.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccessProtocol.Name = "lblAccessProtocol";
            this.lblAccessProtocol.Size = new System.Drawing.Size(155, 23);
            this.lblAccessProtocol.TabIndex = 0;
            this.lblAccessProtocol.Text = "Access Protocol";
            this.lblAccessProtocol.Click += new System.EventHandler(this.lblAccessProtocol_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.BackColor = System.Drawing.Color.Navy;
            this.BtnLogin.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnLogin.Location = new System.Drawing.Point(137, 283);
            this.BtnLogin.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(149, 35);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "Authenticate";
            this.BtnLogin.UseVisualStyleBackColor = false;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            this.BtnLogin.MouseEnter += new System.EventHandler(this.BtnLogin_MouseEnter);
            this.BtnLogin.MouseLeave += new System.EventHandler(this.BtnLogin_MouseLeave);
            this.BtnLogin.MouseHover += new System.EventHandler(this.BtnLogin_MouseHover);
            // 
            // edtPassword
            // 
            this.edtPassword.BackColor = System.Drawing.SystemColors.GrayText;
            this.edtPassword.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtPassword.ForeColor = System.Drawing.SystemColors.Window;
            this.edtPassword.Location = new System.Drawing.Point(87, 216);
            this.edtPassword.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edtPassword.Name = "edtPassword";
            this.edtPassword.Size = new System.Drawing.Size(245, 25);
            this.edtPassword.TabIndex = 5;
            this.edtPassword.Text = "Enter your Password";
            this.edtPassword.Click += new System.EventHandler(this.edtPassword_Click);
            this.edtPassword.TextChanged += new System.EventHandler(this.edtPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblPassword.Location = new System.Drawing.Point(83, 185);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 23);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // edtHeroID
            // 
            this.edtHeroID.BackColor = System.Drawing.SystemColors.GrayText;
            this.edtHeroID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHeroID.ForeColor = System.Drawing.SystemColors.Window;
            this.edtHeroID.Location = new System.Drawing.Point(87, 140);
            this.edtHeroID.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.edtHeroID.Name = "edtHeroID";
            this.edtHeroID.Size = new System.Drawing.Size(245, 25);
            this.edtHeroID.TabIndex = 3;
            this.edtHeroID.Text = "Enter your Hero ID";
            this.edtHeroID.Click += new System.EventHandler(this.edtHeroID_Click);
            this.edtHeroID.TextChanged += new System.EventHandler(this.edtHeroID_TextChanged);
            this.edtHeroID.MouseHover += new System.EventHandler(this.edtHeroID_MouseHover);
            // 
            // lblHeroID
            // 
            this.lblHeroID.AutoSize = true;
            this.lblHeroID.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroID.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblHeroID.Location = new System.Drawing.Point(83, 107);
            this.lblHeroID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHeroID.Name = "lblHeroID";
            this.lblHeroID.Size = new System.Drawing.Size(75, 23);
            this.lblHeroID.TabIndex = 2;
            this.lblHeroID.Text = "HeroID";
            // 
            // lblAccessDescription
            // 
            this.lblAccessDescription.AutoSize = true;
            this.lblAccessDescription.Font = new System.Drawing.Font("Britannic Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccessDescription.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblAccessDescription.Location = new System.Drawing.Point(56, 37);
            this.lblAccessDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAccessDescription.Name = "lblAccessDescription";
            this.lblAccessDescription.Size = new System.Drawing.Size(321, 16);
            this.lblAccessDescription.TabIndex = 1;
            this.lblAccessDescription.Text = "Authenticate to manage her profiles and abilities";
            this.lblAccessDescription.Click += new System.EventHandler(this.lblAccessDescription_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::One_Kick_Heroes_Academy.Properties.Resources._1016;
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(758, 530);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // FrmLockScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::One_Kick_Heroes_Academy.Properties.Resources.LockScreenbg;
            this.ClientSize = new System.Drawing.Size(633, 456);
            this.Controls.Add(this.grpAccessPrototcol);
            this.Controls.Add(this.lblHeroAcademy);
            this.Controls.Add(this.pbLockScreen);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FrmLockScreen";
            this.Text = "LockScreen";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmLockScreen_FormClosed);
            this.Load += new System.EventHandler(this.FrmLockScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbLockScreen)).EndInit();
            this.grpAccessPrototcol.ResumeLayout(false);
            this.grpAccessPrototcol.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbLockScreen;
        private System.Windows.Forms.Label lblHeroAcademy;
        private System.Windows.Forms.GroupBox grpAccessPrototcol;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.TextBox edtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox edtHeroID;
        private System.Windows.Forms.Label lblHeroID;
        private System.Windows.Forms.Label lblAccessDescription;
        private System.Windows.Forms.Label lblAccessProtocol;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

