/*
 * Created by: Rawaa Al Ghanai
 * Created on: Feb. 28, 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #12 - Pizza Cost 
 * This program asks the user to enter the size of the pizza in inches. 
 * Then given the following, it calculates the cost with 13% HST:
 *      labour cost is $0.75 / pizza, regardless of the size
 *      rent of the shop is $1.00 / pizza, regardless of the size
 *      materials is $0.50 / diameter inch of pizza.
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

namespace PizzaCostRawaa
{
    public partial class frmPizzaCost : Form
    {
        public frmPizzaCost()
        {
            InitializeComponent();
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            // declare local variables
            double diameter, costBeforeTax, costAfterTax;

            // convert diameter to double
            diameter = double.Parse(txtDiameter.Text);

            // calculate the cost before and after the tax
            costBeforeTax = 1.75 + 0.5 * diameter;
            costAfterTax = 1.13 * costBeforeTax;

            // display the cost in the label
            lblCostAnswer.Text = String.Format("${0:0.00}", costAfterTax);

            // show the cost and cost answer labels
            this.lblCost.Show();
            this.lblCostAnswer.Show();

        }

        private void FrmPizzaCost_Load(object sender, EventArgs e)
        {
            // hide the cost and cost answer labels.
            this.lblCost.Hide();
            this.lblCostAnswer.Hide();
        }
    }
}
