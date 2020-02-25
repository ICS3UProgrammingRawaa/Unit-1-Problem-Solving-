namespace MovingCatRawaa
{
    partial class frmMovingCat
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
            this.mnuFile = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mniCat2 = new System.Windows.Forms.ToolStripMenuItem();
            this.picCat = new System.Windows.Forms.PictureBox();
            this.cat3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).BeginInit();
            this.SuspendLayout();
            // 
            // mnuFile
            // 
            this.mnuFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniCat});
            this.mnuFile.Location = new System.Drawing.Point(0, 0);
            this.mnuFile.Name = "mnuFile";
            this.mnuFile.Size = new System.Drawing.Size(800, 24);
            this.mnuFile.TabIndex = 0;
            this.mnuFile.Text = "menuStrip1";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniExit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            this.mniFile.Click += new System.EventHandler(this.MniFile_Click);
            // 
            // mniExit
            // 
            this.mniExit.Name = "mniExit";
            this.mniExit.Size = new System.Drawing.Size(180, 22);
            this.mniExit.Text = "Exit";
            this.mniExit.Click += new System.EventHandler(this.MniExit_Click);
            // 
            // mniCat
            // 
            this.mniCat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniCat1,
            this.mniCat2,
            this.cat3ToolStripMenuItem});
            this.mniCat.Name = "mniCat";
            this.mniCat.Size = new System.Drawing.Size(37, 20);
            this.mniCat.Text = "Cat";
            this.mniCat.Click += new System.EventHandler(this.MniCat_Click);
            // 
            // mniCat1
            // 
            this.mniCat1.Name = "mniCat1";
            this.mniCat1.Size = new System.Drawing.Size(104, 22);
            this.mniCat1.Text = "Cat 1";
            this.mniCat1.Click += new System.EventHandler(this.MniCat1_Click);
            // 
            // mniCat2
            // 
            this.mniCat2.Name = "mniCat2";
            this.mniCat2.Size = new System.Drawing.Size(104, 22);
            this.mniCat2.Text = "Cat 2";
            this.mniCat2.Click += new System.EventHandler(this.Cat2ToolStripMenuItem_Click);
            // 
            // picCat
            // 
            this.picCat.Location = new System.Drawing.Point(259, 116);
            this.picCat.Name = "picCat";
            this.picCat.Size = new System.Drawing.Size(225, 218);
            this.picCat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCat.TabIndex = 1;
            this.picCat.TabStop = false;
            this.picCat.Click += new System.EventHandler(this.PicCat_Click);
            // 
            // cat3ToolStripMenuItem
            // 
            this.cat3ToolStripMenuItem.Name = "cat3ToolStripMenuItem";
            this.cat3ToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.cat3ToolStripMenuItem.Text = "Cat 3 ";
            this.cat3ToolStripMenuItem.Click += new System.EventHandler(this.Cat3ToolStripMenuItem_Click);
            // 
            // frmMovingCat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.picCat);
            this.Controls.Add(this.mnuFile);
            this.MainMenuStrip = this.mnuFile;
            this.Name = "frmMovingCat";
            this.Text = "Moving Cat By Rawaa";
            this.mnuFile.ResumeLayout(false);
            this.mnuFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuFile;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniExit;
        private System.Windows.Forms.ToolStripMenuItem mniCat;
        private System.Windows.Forms.ToolStripMenuItem mniCat1;
        private System.Windows.Forms.ToolStripMenuItem mniCat2;
        private System.Windows.Forms.PictureBox picCat;
        private System.Windows.Forms.ToolStripMenuItem cat3ToolStripMenuItem;
    }
}

