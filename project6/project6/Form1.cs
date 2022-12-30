using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            label1.Text = rnd.Next(100).ToString();
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            Random colorRnd = new Random();
            int clr = colorRnd.Next(3);
            switch (clr)
            {
                case 0:
                    label1.ForeColor = Color.Red;
                    break;
                case 1:
                    label1.ForeColor = Color.Blue;
                    break;
                case 2:
                    label1.ForeColor = Color.Green;
                    break;
                default:
                    label1.ForeColor = Color.Black;
                    break;
            }
            
            MessageBox.Show(clr.ToString());
        }
    }
}
