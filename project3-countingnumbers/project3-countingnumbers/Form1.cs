using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project3_countingnumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int firstNumber = 0, lastNumber = 0;
        int divisibleTerm = 1;
        
        int controlNumber = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("10");
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            string divisibleNumber = "";

            if(textBox1.Text.Trim()=="" || textBox2.Text.Trim() == "")
            {
                MessageBox.Show("Please fill the necessary fields");
            }

            else if(comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("please select divisible term");
            }

            else
            {
                firstNumber = Convert.ToInt32(textBox1.Text);
                lastNumber = Convert.ToInt32(textBox2.Text);
                MessageBox.Show("Divisible " + divisibleTerm + " From " + firstNumber + " To " + lastNumber);
                for (int i = firstNumber; i < lastNumber; i++)
                {
                    if (i % divisibleTerm == 0)
                    {
                        divisibleNumber += i.ToString() + " ";
                        if (controlNumber % 10 == 0)
                        {
                            divisibleNumber += Environment.NewLine;
                        }
                        controlNumber++;
                    }

                    txtDivisibleNumbers.Text = divisibleNumber;
                }
            }

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            divisibleTerm = Convert.ToInt32(comboBox1.SelectedItem);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void radioBlue_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlue.Checked)
            {
                radioBlack.Checked = false;
                radioGreen.Checked = false;
                radioRed.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Blue;
            }
        }

        private void radioRed_CheckedChanged(object sender, EventArgs e)
        {
            if (radioRed.Checked)
            {
                radioBlack.Checked = false;
                radioGreen.Checked = false;
                radioBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Red;
            }
        }

        private void radioBlack_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBlack.Checked)
            {
                radioRed.Checked = false;
                radioGreen.Checked = false;
                radioBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Black;
            }
        }

        private void radioGreen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioGreen.Checked)
            {
                radioRed.Checked = false;
                radioBlack.Checked = false;
                radioBlue.Checked = false;
                txtDivisibleNumbers.ForeColor = Color.Green;
            }
        }

        private void chckBold_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBold.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Bold);
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
            }
        }

        private void chckItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (chckItalic.Checked)
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Italic);
            }
            else
            {
                txtDivisibleNumbers.Font = new Font(txtDivisibleNumbers.Font.FontFamily, txtDivisibleNumbers.Font.Size, FontStyle.Regular);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
