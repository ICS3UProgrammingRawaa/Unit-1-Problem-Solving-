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


        }
    }
}
