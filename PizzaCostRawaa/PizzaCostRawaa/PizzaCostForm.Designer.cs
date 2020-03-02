namespace PizzaCostRawaa
{
    partial class frmPizzaCost
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
            this.lblDiameter = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblCostAnswer = new System.Windows.Forms.Label();
            this.txtDiameter = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDiameter
            // 
            this.lblDiameter.AutoSize = true;
            this.lblDiameter.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiameter.Location = new System.Drawing.Point(64, 129);
            this.lblDiameter.Name = "lblDiameter";
            this.lblDiameter.Size = new System.Drawing.Size(365, 23);
            this.lblDiameter.TabIndex = 0;
            this.lblDiameter.Text = "Enter the diameter of the pizza (in inches):";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.Location = new System.Drawing.Point(64, 305);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(228, 23);
            this.lblCost.TabIndex = 1;
            this.lblCost.Text = "The cost (including tax) is:";
            // 
            // lblCostAnswer
            // 
            this.lblCostAnswer.AutoSize = true;
            this.lblCostAnswer.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCostAnswer.Location = new System.Drawing.Point(511, 305);
            this.lblCostAnswer.Name = "lblCostAnswer";
            this.lblCostAnswer.Size = new System.Drawing.Size(37, 23);
            this.lblCostAnswer.TabIndex = 2;
            this.lblCostAnswer.Text = "???";
            // 
            // txtDiameter
            // 
            this.txtDiameter.Location = new System.Drawing.Point(491, 132);
            this.txtDiameter.Name = "txtDiameter";
            this.txtDiameter.Size = new System.Drawing.Size(114, 20);
            this.txtDiameter.TabIndex = 3;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.White;
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(169, 202);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(177, 41);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate Cost";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // frmPizzaCost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtDiameter);
            this.Controls.Add(this.lblCostAnswer);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblDiameter);
            this.Name = "frmPizzaCost";
            this.Text = "Pizza Cost By Rawaa";
            this.Load += new System.EventHandler(this.FrmPizzaCost_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDiameter;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label lblCostAnswer;
        private System.Windows.Forms.TextBox txtDiameter;
        private System.Windows.Forms.Button btnCalculate;
    }
}

