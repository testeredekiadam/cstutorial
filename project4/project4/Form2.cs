using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Employee personelDetail = new Employee();

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = personelDetail.EmployeeID.ToString();
            textBox2.Text = personelDetail.Name;
            textBox3.Text = personelDetail.Age.ToString();
        }
    }
}
