using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project15_delegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public delegate void fillTextBox(int x);
        string textValue = "";

        public void FillMathNote(int ExamNote)
        {
            textValue += "Your Math Note is: " + ExamNote + Environment.NewLine;
        }

        public void FillChemistryNote(int ExamNote)
        {
            textValue += "Your Chemistry Note is: " + ExamNote + Environment.NewLine;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public void ShowinTextBox()
        {
            textBox1.Text = textValue;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fillTextBox fillText = FillMathNote;
            fillText += FillChemistryNote;
            fillText(80);
            fillText -= FillMathNote;
            fillText(60);
            ShowinTextBox();
        }
    }
}
