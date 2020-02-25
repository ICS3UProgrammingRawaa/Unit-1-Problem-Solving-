/*
 * Created by: Rawaa Al Ghanai
 * Created on: Feb. 19 2020
 * Created for: ICS3U Programming
 * Daily Assignment – Day #9 - Name of Program
 * This program displays a menu strip with a drop-down menu with two menu items. 
 * When I click on each menu item, the picture in the picture box changes accordingly. 
 * When I click on the Exit menu item, the program closes.
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

namespace MovingCatRawaa
{
    public partial class frmMovingCat : Form
    {
        public frmMovingCat()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Cat2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chnage the picture to cat 2
            this.picCat.Image = Properties.Resources.cat2;
        }

        private void MniExit_Click(object sender, EventArgs e)
        {
            // Exit the Program
            this.Close();

        }

        private void MniCat1_Click(object sender, EventArgs e)
        {
            // change the image to cat 1
            this.picCat.Image = Properties.Resources.cat1;
        }

        private void MniCat3_Click(object sender, EventArgs e)
        {
            // change the image to cat 3 
            this.picCat.Image = Properties.Resources.cat3;
        }

        private void MniCat4_Click(object sender, EventArgs e)
        {
            // change image to cat 4
            this.picCat.Image = Properties.Resources.garfield_final; 
        }
    }
}
