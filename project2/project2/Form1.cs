using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region
            string Name = txtName.Text;
            string Surname = txtSurname.Text;
            string NameSurname = Name + Surname;
            frmShowData frmShow = new frmShowData();
            frmShow.lblNameSurname.Text = NameSurname;
            frmShow.Show();
            #endregion

        }
    }
}
