using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project12_polymorph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btn1Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1);
            string messageText = teacher.GetValues();
            textBox1.Text = messageText;
        }

        private void btn2Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Firat");
            string messageText = teacher.GetValues();
            textBox1.Text = messageText;
        }

        private void btn3Parameter_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Firat", 2000);
            string messageText = teacher.GetValues();
            textBox1.Text = messageText;
        }

        private void btn4Parameters_Click(object sender, EventArgs e)
        {
            Teacher teacher = new Teacher();
            teacher.SetValues(1, "Firat", 2000, "Manager");
            string messageText = teacher.GetValues();
            textBox1.Text = messageText;
        }

        private void virtualButton_Click(object sender, EventArgs e)
        {
            Employee2 employee = new Employee2();
            string messageText = employee.SetValues(1, "Firat", 2000);
            textBox1.Text = messageText;
        }

        private void overrideButton_Click(object sender, EventArgs e)
        {
            Teacher2 teacher = new Teacher2();
            string messageText = teacher.SetValues(1, "Firat", 2000);
            textBox1.Text = messageText;
        }
    }
}
