using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value = counter;
            label1.Text = Convert.ToString(counter);
            counter--;

            if(counter == 0)
            {
                timer1.Stop();
                MessageBox.Show("Done!");
            }
            
        }

        int counter = 60;
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = Convert.ToString(counter);
        }
    }
}
