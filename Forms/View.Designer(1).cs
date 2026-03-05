namespace One_Kick_Heroes_Academy.Forms
{
    partial class frmHeroView
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
            this.edtHeroSearch = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dvgViewHeroRecords = new System.Windows.Forms.DataGridView();
            this.pcOneKickHeroAcademy = new System.Windows.Forms.PictureBox();
            this.lblOneKickHeroAcademy = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgViewHeroRecords)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcOneKickHeroAcademy)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSuperheroRecords
            // 
            this.lblSuperheroRecords.AutoSize = true;
            this.lblSuperheroRecords.Font = new System.Drawing.Font("Microsoft YaHei UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSuperheroRecords.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSuperheroRecords.Location = new System.Drawing.Point(236, 111);
            this.lblSuperheroRecords.Name = "lblSuperheroRecords";
            this.lblSuperheroRecords.Size = new System.Drawing.Size(275, 31);
            this.lblSuperheroRecords.TabIndex = 0;
            this.lblSuperheroRecords.Text = "SUPERHERO RECORDS";
            // 
            // edtHeroSearch
            // 
            this.edtHeroSearch.BackColor = System.Drawing.SystemColors.MenuText;
            this.edtHeroSearch.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edtHeroSearch.ForeColor = System.Drawing.SystemColors.Window;
            this.edtHeroSearch.Location = new System.Drawing.Point(242, 157);
            this.edtHeroSearch.Name = "edtHeroSearch";
            this.edtHeroSearch.Size = new System.Drawing.Size(432, 29);
            this.edtHeroSearch.TabIndex = 1;
            this.edtHeroSearch.Text = "Search heroIDs....";
            this.edtHeroSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.edtHeroSearch_MouseClick);
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.Blue;
            this.btnFilter.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFilter.Location = new System.Drawing.Point(694, 157);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(103, 30);
            this.btnFilter.TabIndex = 2;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            this.btnFilter.MouseHover += new System.EventHandler(this.btnFilter_MouseHover);
            // 
            // dvgViewHeroRecords
            // 
            this.dvgViewHeroRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgViewHeroRecords.Location = new System.Drawing.Point(233, 218);
            this.dvgViewHeroRecords.Name = "dvgViewHeroRecords";
            this.dvgViewHeroRecords.RowHeadersWidth = 51;
            this.dvgViewHeroRecords.RowTemplate.Height = 24;
            this.dvgViewHeroRecords.Size = new System.Drawing.Size(800, 301);
            this.dvgViewHeroRecords.TabIndex = 4;
            // 
            // pcOneKickHeroAcademy
            // 
            this.pcOneKickHeroAcademy.BackgroundImage = global::One_Kick_Heroes_Academy.Properties.Resources.lockScreenICO1;
            this.pcOneKickHeroAcademy.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcOneKickHeroAcademy.Location = new System.Drawing.Point(31, 22);
            this.pcOneKickHeroAcademy.Name = "pcOneKickHeroAcademy";
            this.pcOneKickHeroAcademy.Size = new System.Drawing.Size(59, 47);
            this.pcOneKickHeroAcademy.TabIndex = 5;
            this.pcOneKickHeroAcademy.TabStop = false;
            // 
            // lblOneKickHeroAcademy
            // 
            this.lblOneKickHeroAcademy.AutoSize = true;
            this.lblOneKickHeroAcademy.Font = new System.Drawing.Font("Showcard Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOneKickHeroAcademy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOneKickHeroAcademy.Location = new System.Drawing.Point(115, 22);
            this.lblOneKickHeroAcademy.Name = "lblOneKickHeroAcademy";
            this.lblOneKickHeroAcademy.Size = new System.Drawing.Size(384, 35);
            this.lblOneKickHeroAcademy.TabIndex = 6;
            this.lblOneKickHeroAcademy.Text = "ONE KICK HERO ACADEMY";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DarkGreen;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnRefresh.Location = new System.Drawing.Point(899, 546);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(134, 36);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            this.btnRefresh.MouseHover += new System.EventHandler(this.btnRefresh_MouseHover);
            // 
            // frmHeroView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImage = global::One_Kick_Heroes_Academy.Properties.Resources.Dashboard_bg;
            this.ClientSize = new System.Drawing.Size(1189, 594);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblOneKickHeroAcademy);
            this.Controls.Add(this.pcOneKickHeroAcademy);
            this.Controls.Add(this.dvgViewHeroRecords);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.edtHeroSearch);
            this.Controls.Add(this.lblSuperheroRecords);
            this.Name = "frmHeroView";
            this.Text = "View Heroes";
            this.Load += new System.EventHandler(this.frmHeroView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgViewHeroRecords)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcOneKickHeroAcademy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSuperheroRecords;
        private System.Windows.Forms.TextBox edtHeroSearch;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridView dvgViewHeroRecords;
        private System.Windows.Forms.PictureBox pcOneKickHeroAcademy;
        private System.Windows.Forms.Label lblOneKickHeroAcademy;
        private System.Windows.Forms.Button btnRefresh;
    }
}