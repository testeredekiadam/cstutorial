using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace firstProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string messagetext = "Do you want to close window?";
            //string messagetitle = "Close window";
            //MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            //DialogResult result = MessageBox.Show(messagetext, messagetitle, buttons);
            //if(result==DialogResult.Yes)
            //{
            //    this.Close();
            //}
            //else if (result == DialogResult.No)
            //{
            //    // do nothing
            //}

            //string message = "Did you see icon?";
            //string title = "ok";
            //MessageBox.Show(message, title, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            checkBox1.Checked = false;
            bool control = checkBox1.Checked;

            firstButton.Text = "changed";

            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            //comboBox1.SelectedIndex = 1;
        }

        private void firstButton_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("hello", "hello box");
            firstButton.Text = "Clicked";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "first label";
            label1.BackColor = Color.Red;
            label1.ForeColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string labeltext2 = textBox1.Text;
            label2.Text = labeltext2;
        }

        private void firstButton_KeyPress(object sender, KeyPressEventArgs e)
        {
            firstButton.Text = "Enter";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}

            //// only allow one decimal point
            //if((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}
        }

        private void button3_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = false;
            bool control = radioButton1.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("checked changed");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("checked changed");
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            MessageBox.Show("checked state changed");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string selectedItem = comboBox1.SelectedItem.ToString();

            int valueOrder = comboBox1.SelectedIndex;
            MessageBox.Show(selectedItem + ": " + valueOrder.ToString());
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = "Selected index changed" + comboBox1.SelectedIndex.ToString();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            label5.Text = "Selected value changed" + comboBox1.SelectedItem.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DateTime birthday = dateTimePicker1.Value;
            label7.Text = birthday.AddYears(2).ToShortDateString();
            label8.Text = birthday.AddYears(-2).ToShortDateString();
            MessageBox.Show(birthday.ToString());

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(dateTimePicker1.Value.ToShortDateString());
        }
    }
}
