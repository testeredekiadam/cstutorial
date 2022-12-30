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

namespace project19_namepath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string ourfile = @"C:\Users\erkol\OneDrive\Desktop\asd.jpg";
            string directorypath = Path.GetDirectoryName(ourfile) + Environment.NewLine;
            directorypath += Path.GetExtension(ourfile) + Environment.NewLine;
            directorypath += Path.GetFileName(ourfile) + Environment.NewLine;
            directorypath += Path.GetFileNameWithoutExtension(ourfile) + Environment.NewLine;
            directorypath += Path.GetPathRoot(ourfile) + Environment.NewLine;
            directorypath += Path.GetFullPath(ourfile) + Environment.NewLine;

            textBox1.Text = directorypath;
        }
    }
}
