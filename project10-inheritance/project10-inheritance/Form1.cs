﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project10_inheritance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues();
            teacher.SetValues2();
            string allvalues = "";
            allvalues += teacher.Name + Environment.NewLine;
            allvalues += teacher.Gender + Environment.NewLine;
            allvalues += teacher.Age + Environment.NewLine;
            allvalues += teacher.Branch + Environment.NewLine;
            textBox1.Text = allvalues;
        }
    }
}
