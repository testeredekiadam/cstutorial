using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project11_interface
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        interface Computer
        {
            void GetDesktops();
            void GetLaptops();
        }

        interface DellComputer
        {
            void GetMark();
        }

        class DellComputers : Computer, DellComputer
        {

            public string Name { get; set; }
            public double Price { get; set; }
            public string Mark { get; set; }

            public void GetDesktops()
            {
                Name = "Desktop1";
                Price = 2000;
            }

            public void GetLaptops()
            {
                Name = "Laptop1";
                Price = 1500;
            }

            public void GetMark()
            {
                Mark = "Dell";
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DellComputers dell = new DellComputers();
            dell.GetLaptops();
            dell.GetMark();
            string textValue = "Name: " + dell.Name + Environment.NewLine;
            textValue += "Price: " + dell.Price + Environment.NewLine;
            textValue += "Mark: " + dell.Mark + Environment.NewLine;
            textBox1.Text = textValue;
        }
    }
}
