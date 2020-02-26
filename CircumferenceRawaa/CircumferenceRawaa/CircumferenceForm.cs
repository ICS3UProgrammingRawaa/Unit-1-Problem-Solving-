/*
 * Created by: Rawaa Al Ghanai
 * Created on: Feb. 25, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #10 - Name of Program
 * This program  asks the user for the radius and then calculates the circumference of the circle.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CircumferenceRawaa
{
    public partial class frmCircumference : Form
    {
        public frmCircumference()
        {
            InitializeComponent();
        }

        private void FrmCircumference_Load(object sender, EventArgs e)
        {
            lblCircumference.Hide();
            lblAnswer.Hide();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables 
            double radius, answer;
            double circumference; 

            // parse string from the text box to a double 
            radius = double.Parse(txtRadius.Text);

            // calculate the circumference 
            answer = 2 * Math.PI * radius;
            lblAnswer.Show();
            lblCircumference.Show();
            this.lblAnswer.Text = Convert.ToString(answer) + "cm";


        }

        private void LblCircumference_Click(object sender, EventArgs e)
        {
            
            
        }

        private void LblAnswer_Click(object sender, EventArgs e)
        {
            
        }
    }
}
