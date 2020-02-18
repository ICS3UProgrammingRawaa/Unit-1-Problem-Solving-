namespace SchoolMascotRawaa
{
    partial class frmSchoolMascot
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
            this.mnuProgram = new System.Windows.Forms.MenuStrip();
            this.grbSchool = new System.Windows.Forms.GroupBox();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblMascot = new System.Windows.Forms.Label();
            this.mniSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniMotherTeresa = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSaintPatrick = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSaintMatthew = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProgram.SuspendLayout();
            this.grbSchool.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuProgram
            // 
            this.mnuProgram.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchools});
            this.mnuProgram.Location = new System.Drawing.Point(0, 0);
            this.mnuProgram.Name = "mnuProgram";
            this.mnuProgram.Size = new System.Drawing.Size(800, 24);
            this.mnuProgram.TabIndex = 0;
            this.mnuProgram.Text = "School Mascot By Rawaa";
            // 
            // grbSchool
            // 
            this.grbSchool.Controls.Add(this.lblMascot);
            this.grbSchool.Controls.Add(this.lblSchool);
            this.grbSchool.Location = new System.Drawing.Point(232, 137);
            this.grbSchool.Name = "grbSchool";
            this.grbSchool.Size = new System.Drawing.Size(253, 137);
            this.grbSchool.TabIndex = 1;
            this.grbSchool.TabStop = false;
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSchool.Location = new System.Drawing.Point(6, 28);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(175, 32);
            this.lblSchool.TabIndex = 2;
            this.lblSchool.Text = "Immaculata";
            this.lblSchool.Click += new System.EventHandler(this.Label1_Click);
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Font = new System.Drawing.Font("Segoe Script", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMascot.Location = new System.Drawing.Point(38, 72);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(83, 33);
            this.lblMascot.TabIndex = 3;
            this.lblMascot.Text = "Saints";
            this.lblMascot.Click += new System.EventHandler(this.LblMascot_Click);
            // 
            // mniSchools
            // 
            this.mniSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniMotherTeresa,
            this.mniSaintPatrick,
            this.mniSaintMatthew});
            this.mniSchools.Name = "mniSchools";
            this.mniSchools.Size = new System.Drawing.Size(60, 20);
            this.mniSchools.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(180, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.MniImmaculata_Click);
            // 
            // mniMotherTeresa
            // 
            this.mniMotherTeresa.Name = "mniMotherTeresa";
            this.mniMotherTeresa.Size = new System.Drawing.Size(180, 22);
            this.mniMotherTeresa.Text = "Mother Teresa ";
            this.mniMotherTeresa.Click += new System.EventHandler(this.MniMotherTeresa_Click);
            // 
            // mniSaintPatrick
            // 
            this.mniSaintPatrick.Name = "mniSaintPatrick";
            this.mniSaintPatrick.Size = new System.Drawing.Size(180, 22);
            this.mniSaintPatrick.Text = "Saint Patrick ";
            this.mniSaintPatrick.Click += new System.EventHandler(this.MniSaintPatrick_Click);
            // 
            // mniSaintMatthew
            // 
            this.mniSaintMatthew.Name = "mniSaintMatthew";
            this.mniSaintMatthew.Size = new System.Drawing.Size(180, 22);
            this.mniSaintMatthew.Text = "Saint Matthew ";
            this.mniSaintMatthew.Click += new System.EventHandler(this.MniSaintMatthew_Click);
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbSchool);
            this.Controls.Add(this.mnuProgram);
            this.MainMenuStrip = this.mnuProgram;
            this.Name = "frmSchoolMascot";
            this.Text = "School Mascot by Rawaa";
            this.Load += new System.EventHandler(this.FrmSchoolMascot_Load);
            this.mnuProgram.ResumeLayout(false);
            this.mnuProgram.PerformLayout();
            this.grbSchool.ResumeLayout(false);
            this.grbSchool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuProgram;
        private System.Windows.Forms.GroupBox grbSchool;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.ToolStripMenuItem mniSchools;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniMotherTeresa;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.ToolStripMenuItem mniSaintPatrick;
        private System.Windows.Forms.ToolStripMenuItem mniSaintMatthew;
    }
}

