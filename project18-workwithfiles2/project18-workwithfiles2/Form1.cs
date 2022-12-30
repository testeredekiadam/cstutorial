using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace project18_workwithfiles2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //File.Create("firstfile.txt");
            if (!File.Exists("secondfile.txt"))
            {
                FileInfo ourFile = new FileInfo("secondfile.txt");
                ourFile.Create();
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (File.Exists("secondfile.txt"))
            {
                File.Delete("secondfile.txt");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.OpenOrCreate, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("This is first Line");
            sw.WriteLine("This is Second Line");
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("third.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string text = "";
            while (!sr.EndOfStream)
            {
                text += sr.ReadLine() + Environment.NewLine;
            }
            sr.Close();
            fs.Close();
            textBox1.Text = text;
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            File.Copy("secondfile.txt", @"C:\Users\erkol\OneDrive\Desktop\cstutorial\secondfile.txt");
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            FileInfo ourfile = new FileInfo("secondfile.txt");
            string name = ourfile.Name;
            string accesstime = ourfile.LastAccessTime.ToString();
            string text = "Filename: " + name + Environment.NewLine;
            text += "Edit time: " + accesstime;
            textBox1.Text = text;
            MessageBox.Show(ourfile.FullName);
        }
    }
}
