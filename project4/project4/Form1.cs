using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Employee personelDetail = new Employee();

        private void setValue_Click(object sender, EventArgs e)
        {
            personelDetail.EmployeeID = Convert.ToInt32(txtEmployeeId.Text);
            personelDetail.Name = txtName.Text;
            personelDetail.Age = Convert.ToInt32(txtAge.Text);
            MessageBox.Show("All Data Received");
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.personelDetail = personelDetail;
            frm.ShowDialog();
        }
    }
}
