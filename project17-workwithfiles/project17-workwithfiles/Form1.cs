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

namespace project17_workwithfiles
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Directory.CreateDirectory("temp");
            //DirectoryInfo dr = new DirectoryInfo("temp2");
            //DirectoryInfo dr = new DirectoryInfo(@"C:\Users\erkol\OneDrive\Desktop\cstutorial\temp");
            //dr.Create();
            //MessageBox.Show("Folder was created");

            if (!Directory.Exists("folder2"))
            {
                DirectoryInfo dr = new DirectoryInfo("folder2");
                dr.Create();
                string accessTime = dr.CreationTime.ToString();
                MessageBox.Show("Created at: " + accessTime);
            }
            else
            {
                DirectoryInfo dr = new DirectoryInfo("folder2");
                string accessTime = dr.LastAccessTime.ToString();
                MessageBox.Show("Changed at: " + accessTime);
            }
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            Directory.Move("temp2", @"C:\Users\erkol\OneDrive\Desktop\cstutorial\temp2");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (Directory.Exists("folder2"))
            {
                Directory.Delete("folder2");
                MessageBox.Show("Folder deleted");
            }

            else
            {
                MessageBox.Show("Folder not found");
            }
            
        }
    }
}
