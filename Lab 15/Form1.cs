using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_15
{
    public partial class Form1 : Form
    {
        Cylinder cylinder = new Cylinder();

        public Form1()
        {
            InitializeComponent();
        }

        //private void bCount_Click(object sender, EventArgs e)
        //{
        //    lResult.Text = cylinder.Count(tBH.Text, tBR.Text);
        //}

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bCount_Click_1(object sender, EventArgs e)
        {
            lResult.Text = cylinder.Count(tBH.Text, tBR.Text);
        }
    }
}
