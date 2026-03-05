namespace One_Kick_Heroes_Academy.Forms
{
    partial class frmUpdateHeroes
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
            this.lblSuperheroRecords = new System.Windows.Forms.Label();
            this.edtSearchHeroes = new System.Windows.Forms.TextBox();
            this.displayHerosLog = new System.Windows.Forms.Button();
            this.dvgEditHeroes = new System.Windows.Forms.DataGridView();
            this.grpEditRecords = new System.Windows.Forms.GroupBox();
            this.edtDelete = new System.Windows.Forms.Button();
            this.edtUpdate = new System.Windows.Forms.Button();
            this.edtheroExamScore = new System.Windows.Forms.TextBox();
            this.lblHeroExamScore = new System.Windows.Forms.Label();
            this.edtHeroSuperPower = new System.Windows.Forms.TextBox();
            this.lblHeroSuperpower = new System.Windows.Forms.Label();
            this.edtHeroAge = new System.Windows.Forms.TextBox();
            this.lblHeroAge = new System.Windows.Forms.Label();
            this.edtHeroName = new System.Windows.Forms.TextBox();
            this.lblHeroName = new System.Windows.Forms.Label();
            this.edtHeroID = new System.Windows.Forms.TextBox();
            this.lblHeroID = new System.Windows.Forms.Label();
            this.lblEditRecords = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblOneKickHeroAcademy = new System.Windows.Forms.Label();
            this.pcOneKickHeroAcadmy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dvgEditHeroes)).BeginInit();
            this.grpEditRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcOneKickHeroAcadmy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuperheroRecords
            // 
            this.lblSuperheroRecords.AutoSize = true;
            this.lblSuperheroRecords.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperheroRecords.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSuperheroRecords.Location = new System.Drawing.Point(88, 102);
            this.lblSuperheroRecords.Name = "lblSuperheroRecords";
            this.lblSuperheroRecords.Size = new System.Drawing.Size(275, 31);
            this.lblSuperheroRecords.TabIndex = 0;
            this.lblSuperheroRecords.Text = "SUPERHERO RECORDS";
            // 
            // edtSearchHeroes
            // 
            this.edtSearchHeroes.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edtSearchHeroes.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtSearchHeroes.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.edtSearchHeroes.Location = new System.Drawing.Point(88, 156);
            this.edtSearchHeroes.Name = "edtSearchHeroes";
            this.edtSearchHeroes.Size = new System.Drawing.Size(355, 29);
            this.edtSearchHeroes.TabIndex = 1;
            this.edtSearchHeroes.Text = "Search HeroIDs....";
            this.edtSearchHeroes.Click += new System.EventHandler(this.edtSearchHeroes_Click);
            // 
            // displayHerosLog
            // 
            this.displayHerosLog.BackColor = System.Drawing.Color.Blue;
            this.displayHerosLog.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayHerosLog.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.displayHerosLog.Location = new System.Drawing.Point(481, 148);
            this.displayHerosLog.Name = "displayHerosLog";
            this.displayHerosLog.Size = new System.Drawing.Size(119, 37);
            this.displayHerosLog.TabIndex = 2;
            this.displayHerosLog.Text = "Search";
            this.displayHerosLog.UseVisualStyleBackColor = false;
            this.displayHerosLog.Click += new System.EventHandler(this.displayHerosLog_Click);
            // 
            // dvgEditHeroes
            // 
            this.dvgEditHeroes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgEditHeroes.Location = new System.Drawing.Point(88, 199);
            this.dvgEditHeroes.Name = "dvgEditHeroes";
            this.dvgEditHeroes.RowHeadersWidth = 51;
            this.dvgEditHeroes.RowTemplate.Height = 24;
            this.dvgEditHeroes.Size = new System.Drawing.Size(752, 346);
            this.dvgEditHeroes.TabIndex = 4;
            this.dvgEditHeroes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEditHeroes_CellClick);
            this.dvgEditHeroes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgEditHeroes_CellContentClick);
            this.dvgEditHeroes.SelectionChanged += new System.EventHandler(this.dvgEditHeroes_SelectionChanged);
            // 
            // grpEditRecords
            // 
            this.grpEditRecords.Controls.Add(this.edtDelete);
            this.grpEditRecords.Controls.Add(this.edtUpdate);
            this.grpEditRecords.Controls.Add(this.edtheroExamScore);
            this.grpEditRecords.Controls.Add(this.lblHeroExamScore);
            this.grpEditRecords.Controls.Add(this.edtHeroSuperPower);
            this.grpEditRecords.Controls.Add(this.lblHeroSuperpower);
            this.grpEditRecords.Controls.Add(this.edtHeroAge);
            this.grpEditRecords.Controls.Add(this.lblHeroAge);
            this.grpEditRecords.Controls.Add(this.edtHeroName);
            this.grpEditRecords.Controls.Add(this.lblHeroName);
            this.grpEditRecords.Controls.Add(this.edtHeroID);
            this.grpEditRecords.Controls.Add(this.lblHeroID);
            this.grpEditRecords.Controls.Add(this.lblEditRecords);
            this.grpEditRecords.Location = new System.Drawing.Point(871, 102);
            this.grpEditRecords.Name = "grpEditRecords";
            this.grpEditRecords.Size = new System.Drawing.Size(333, 510);
            this.grpEditRecords.TabIndex = 5;
            this.grpEditRecords.TabStop = false;
            // 
            // edtDelete
            // 
            this.edtDelete.BackColor = System.Drawing.Color.Red;
            this.edtDelete.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edtDelete.Location = new System.Drawing.Point(181, 431);
            this.edtDelete.Name = "edtDelete";
            this.edtDelete.Size = new System.Drawing.Size(111, 36);
            this.edtDelete.TabIndex = 12;
            this.edtDelete.Text = "Delete";
            this.edtDelete.UseVisualStyleBackColor = false;
            this.edtDelete.Click += new System.EventHandler(this.edtDelete_Click_1);
            // 
            // edtUpdate
            // 
            this.edtUpdate.BackColor = System.Drawing.Color.Blue;
            this.edtUpdate.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtUpdate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edtUpdate.Location = new System.Drawing.Point(38, 431);
            this.edtUpdate.Name = "edtUpdate";
            this.edtUpdate.Size = new System.Drawing.Size(110, 36);
            this.edtUpdate.TabIndex = 11;
            this.edtUpdate.Text = "Update";
            this.edtUpdate.UseVisualStyleBackColor = false;
            this.edtUpdate.Click += new System.EventHandler(this.edtUpdate_Click);
            // 
            // edtheroExamScore
            // 
            this.edtheroExamScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edtheroExamScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtheroExamScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edtheroExamScore.Location = new System.Drawing.Point(30, 352);
            this.edtheroExamScore.Name = "edtheroExamScore";
            this.edtheroExamScore.Size = new System.Drawing.Size(262, 29);
            this.edtheroExamScore.TabIndex = 10;
            // 
            // lblHeroExamScore
            // 
            this.lblHeroExamScore.AutoSize = true;
            this.lblHeroExamScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeroExamScore.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroExamScore.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeroExamScore.Location = new System.Drawing.Point(25, 322);
            this.lblHeroExamScore.Name = "lblHeroExamScore";
            this.lblHeroExamScore.Size = new System.Drawing.Size(123, 27);
            this.lblHeroExamScore.TabIndex = 9;
            this.lblHeroExamScore.Text = "Exam Score";
            // 
            // edtHeroSuperPower
            // 
            this.edtHeroSuperPower.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edtHeroSuperPower.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHeroSuperPower.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edtHeroSuperPower.Location = new System.Drawing.Point(30, 283);
            this.edtHeroSuperPower.Name = "edtHeroSuperPower";
            this.edtHeroSuperPower.Size = new System.Drawing.Size(262, 29);
            this.edtHeroSuperPower.TabIndex = 8;
            // 
            // lblHeroSuperpower
            // 
            this.lblHeroSuperpower.AutoSize = true;
            this.lblHeroSuperpower.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeroSuperpower.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroSuperpower.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeroSuperpower.Location = new System.Drawing.Point(29, 253);
            this.lblHeroSuperpower.Name = "lblHeroSuperpower";
            this.lblHeroSuperpower.Size = new System.Drawing.Size(129, 27);
            this.lblHeroSuperpower.TabIndex = 7;
            this.lblHeroSuperpower.Text = "Superpower";
            // 
            // edtHeroAge
            // 
            this.edtHeroAge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edtHeroAge.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHeroAge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edtHeroAge.Location = new System.Drawing.Point(30, 221);
            this.edtHeroAge.Name = "edtHeroAge";
            this.edtHeroAge.Size = new System.Drawing.Size(262, 29);
            this.edtHeroAge.TabIndex = 6;
            // 
            // lblHeroAge
            // 
            this.lblHeroAge.AutoSize = true;
            this.lblHeroAge.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeroAge.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroAge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeroAge.Location = new System.Drawing.Point(29, 191);
            this.lblHeroAge.Name = "lblHeroAge";
            this.lblHeroAge.Size = new System.Drawing.Size(50, 27);
            this.lblHeroAge.TabIndex = 5;
            this.lblHeroAge.Text = "Age";
            // 
            // edtHeroName
            // 
            this.edtHeroName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edtHeroName.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHeroName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edtHeroName.Location = new System.Drawing.Point(30, 159);
            this.edtHeroName.Name = "edtHeroName";
            this.edtHeroName.Size = new System.Drawing.Size(262, 29);
            this.edtHeroName.TabIndex = 4;
            // 
            // lblHeroName
            // 
            this.lblHeroName.AutoSize = true;
            this.lblHeroName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeroName.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeroName.Location = new System.Drawing.Point(29, 129);
            this.lblHeroName.Name = "lblHeroName";
            this.lblHeroName.Size = new System.Drawing.Size(69, 27);
            this.lblHeroName.TabIndex = 3;
            this.lblHeroName.Text = "Name";
            // 
            // edtHeroID
            // 
            this.edtHeroID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.edtHeroID.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHeroID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.edtHeroID.Location = new System.Drawing.Point(30, 97);
            this.edtHeroID.Name = "edtHeroID";
            this.edtHeroID.Size = new System.Drawing.Size(262, 29);
            this.edtHeroID.TabIndex = 2;
            // 
            // lblHeroID
            // 
            this.lblHeroID.AutoSize = true;
            this.lblHeroID.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblHeroID.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeroID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHeroID.Location = new System.Drawing.Point(25, 69);
            this.lblHeroID.Name = "lblHeroID";
            this.lblHeroID.Size = new System.Drawing.Size(86, 27);
            this.lblHeroID.TabIndex = 1;
            this.lblHeroID.Text = "Hero ID";
            // 
            // lblEditRecords
            // 
            this.lblEditRecords.AutoSize = true;
            this.lblEditRecords.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditRecords.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEditRecords.Location = new System.Drawing.Point(99, 28);
            this.lblEditRecords.Name = "lblEditRecords";
            this.lblEditRecords.Size = new System.Drawing.Size(149, 27);
            this.lblEditRecords.TabIndex = 0;
            this.lblEditRecords.Text = "EDIT RECORD";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.Red;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(725, 560);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(115, 32);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // lblOneKickHeroAcademy
            // 
            this.lblOneKickHeroAcademy.AutoSize = true;
            this.lblOneKickHeroAcademy.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneKickHeroAcademy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOneKickHeroAcademy.Location = new System.Drawing.Point(151, 29);
            this.lblOneKickHeroAcademy.Name = "lblOneKickHeroAcademy";
            this.lblOneKickHeroAcademy.Size = new System.Drawing.Size(384, 35);
            this.lblOneKickHeroAcademy.TabIndex = 7;
            this.lblOneKickHeroAcademy.Text = "ONE KICK HERO ACADEMY";
            // 
            // pcOneKickHeroAcadmy
            // 
            this.pcOneKickHeroAcadmy.BackgroundImage = global::One_Kick_Heroes_Academy.Properties.Resources.lockScreenICO1;
            this.pcOneKickHeroAcadmy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcOneKickHeroAcadmy.Location = new System.Drawing.Point(66, 12);
            this.pcOneKickHeroAcadmy.Name = "pcOneKickHeroAcadmy";
            this.pcOneKickHeroAcadmy.Size = new System.Drawing.Size(56, 45);
            this.pcOneKickHeroAcadmy.TabIndex = 8;
            this.pcOneKickHeroAcadmy.TabStop = false;
            // 
            // frmUpdateHeroes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImage = global::One_Kick_Heroes_Academy.Properties.Resources.LockScreenbg;
            this.ClientSize = new System.Drawing.Size(1225, 636);
            this.Controls.Add(this.pcOneKickHeroAcadmy);
            this.Controls.Add(this.lblOneKickHeroAcademy);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.grpEditRecords);
            this.Controls.Add(this.dvgEditHeroes);
            this.Controls.Add(this.displayHerosLog);
            this.Controls.Add(this.edtSearchHeroes);
            this.Controls.Add(this.lblSuperheroRecords);
            this.Name = "frmUpdateHeroes";
            this.Text = "Edit Hero Details";
            this.Load += new System.EventHandler(this.frmUpdateHeroes_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dvgEditHeroes)).EndInit();
            this.grpEditRecords.ResumeLayout(false);
            this.grpEditRecords.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcOneKickHeroAcadmy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuperheroRecords;
        private System.Windows.Forms.TextBox edtSearchHeroes;
        private System.Windows.Forms.Button displayHerosLog;
        private System.Windows.Forms.DataGridView dvgEditHeroes;
        private System.Windows.Forms.GroupBox grpEditRecords;
        private System.Windows.Forms.Button edtDelete;
        private System.Windows.Forms.Button edtUpdate;
        private System.Windows.Forms.TextBox edtheroExamScore;
        private System.Windows.Forms.Label lblHeroExamScore;
        private System.Windows.Forms.TextBox edtHeroSuperPower;
        private System.Windows.Forms.Label lblHeroSuperpower;
        private System.Windows.Forms.TextBox edtHeroAge;
        private System.Windows.Forms.Label lblHeroAge;
        private System.Windows.Forms.TextBox edtHeroName;
        private System.Windows.Forms.Label lblHeroName;
        private System.Windows.Forms.TextBox edtHeroID;
        private System.Windows.Forms.Label lblHeroID;
        private System.Windows.Forms.Label lblEditRecords;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblOneKickHeroAcademy;
        private System.Windows.Forms.PictureBox pcOneKickHeroAcadmy;
    }
}