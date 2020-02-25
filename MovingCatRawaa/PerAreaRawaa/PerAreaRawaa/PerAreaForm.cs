/*
 * Created by: Rawaa Al Ghanai
 * Created on: Feb. 24, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Name of Program
 * This program asks the user to enter the width and height of a rectangle into text boxes. 
 * when the user clicks calculate on the calculate button the program calculates the perimeter 
 * and area of the rectangle and displays it in 2 separate labels.
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

namespace PerAreaRawaa
{
    public partial class frmPerArea : Form
    {
        public frmPerArea()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double length, width, perimeter, area;

            // convert the string from each text box to a double 
            length = double.Parse(txtLength.Text);
            width = double.Parse(txtLength.Text);

            // calculate the ares and the perimeter 
            area = length * width;
            perimeter = 2 * (length + width);

            // insert the area and the perimeter into their respective labels 
            this.lblAreaAnswer.Text = Convert.ToString(area) + " squared meters ";
            this.lblPerimeterAnswer.Text = Convert.ToString(perimeter) + "m";

            // display the perimeter and area labels with their respective answers
            this.lblArea.Show();
            this.lblAreaAnswer.Show();
            this.lblPerimeter.Show();
            this.lblPerimeterAnswer.Show();



        }

        private void FrmPerArea_Load(object sender, EventArgs e)
        {
            // hide the perimeter and answer labels and answers until the user clicks on the calculate button
            this.lblPerimeter.Hide();
            this.lblPerimeterAnswer.Hide();

            // hide the area and answer labels and answers until the user clicks on the calculate button
            this.lblArea.Hide();
            this.lblAreaAnswer.Hide();
        }
    }
}
