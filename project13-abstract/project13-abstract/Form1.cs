using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project13_abstract
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        abstract class Vehicle
        {
            public abstract double GetFuelAmount();
        }

        class Bus : Vehicle
        {
            public override double GetFuelAmount()
            {
                return 300;
            }
        }

        class Truck : Vehicle
        {
            override public double GetFuelAmount()
            {
                return 500;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = "";
            Vehicle vc;
            vc = new Bus();
            double busfuel = vc.GetFuelAmount();
            text += "Bus Fuel Amount is: " + busfuel.ToString() + Environment.NewLine;
            vc = new Truck();
            double truckfuel = vc.GetFuelAmount();
            text += "Truck Fuel Amount is: " + truckfuel.ToString() + Environment.NewLine;
            textBox1.Text = text;
        }
    }
}
