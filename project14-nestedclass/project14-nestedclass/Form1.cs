﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project14_nestedclass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public partial class Employee
        {
            public int EmployeeID { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
        }

        public partial class Employee
        {
            public void SetValues()
            {
                Name = "Charles";
                EmployeeID = 1;
                Salary = 5000;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public sealed class sealedclass
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee();
            emp.SetValues();
            textBox1.Text += emp.EmployeeID + Environment.NewLine;
            textBox1.Text += emp.Name + Environment.NewLine;
            textBox1.Text += emp.Salary + Environment.NewLine;
        }
    }
}
