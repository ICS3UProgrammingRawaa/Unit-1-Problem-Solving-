/*
 * Created by: Rawaa Al Ghanai
 * Created on: Feb. 18 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #8 - Name of Program
 * This program that has a group box with two labels representing the school 
 * and mascot. When you click on the menu item, the school and mascot changes accordingly.
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

namespace SchoolMascotRawaa
{
    public partial class frmSchoolMascot : Form
    {
        public frmSchoolMascot()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void MniMotherTeresa_Click(object sender, EventArgs e)
        {
            // Change the labels to reflect Mother Teresa
            this.lblSchool.Text = "Mother Teresa";
            this.lblMascot.Text = "Titans";
        }

        private void LblMascot_Click(object sender, EventArgs e)
        {
           
        }

        private void MniImmaculata_Click(object sender, EventArgs e)
        {
            // Change the labels to reflect Immaculata
            this.lblSchool.Text = "Immaculata";
            this.lblMascot.Text = "Saints";

        }

        private void MniSaintPatrick_Click(object sender, EventArgs e)
        {
            // Change the labels to reflect Saint Patrick
            this.lblSchool.Text = "Saint Patrick";
            this.lblMascot.Text = "Fishing Irish";
        }

        private void MniSaintMatthew_Click(object sender, EventArgs e)
        {
            // Change the labels to reflect Saint Matthew
            this.lblSchool.Text = "Saint Matthew";
            this.lblMascot.Text = "Tigers";
        }

        private void FrmSchoolMascot_Load(object sender, EventArgs e)
        {

        }
    }
}
