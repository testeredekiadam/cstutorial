using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;


namespace PersonalTracking
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = General.isNumber(e);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserNo.Text.Trim() == "" || txtPassword.Text.Trim() == "")
                MessageBox.Show("Please enter userno and password");
            else

            {
                List<EMPLOYEE> employeeList = EmployeeBLL.GetEmployees(Convert.ToInt32(txtUserNo.Text), txtPassword.Text);
                if(employeeList.Count == 0)
                {
                    MessageBox.Show("Please control your informations");
                }
                else
                {
                    EMPLOYEE employee = new EMPLOYEE();
                    employee = employeeList.First();
                    UserStatic.EmployeeID = employee.ID;
                    UserStatic.UserNo = employee.UserNo;
                    UserStatic.isAdmin = employee.isAdmin;
                    FrmMain frm = new FrmMain();
                    this.Hide();
                    frm.ShowDialog();
                }
            }
        }
    }
}
