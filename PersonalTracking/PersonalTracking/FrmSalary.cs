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
using DAL.DTO;

namespace PersonalTracking
{
    public partial class FrmSalary : Form
    {
        public FrmSalary()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        SalaryDTO dto = new SalaryDTO();
        private bool combofull = false;
        public SalaryDetailsDTO detail = new SalaryDetailsDTO();
        public bool isUpdate = false;
        private void FrmSalary_Load(object sender, EventArgs e)
        {
            dto = SalaryBLL.GetAll();

            if (!isUpdate)
            {
                dataGridView1.DataSource = dto.Employees;
                /*
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].HeaderText = "User No";
                dataGridView1.Columns[3].HeaderText = "Name";
                dataGridView1.Columns[4].HeaderText = "Surname";
                dataGridView1.Columns[5].Visible = false;
                dataGridView1.Columns[6].Visible = false;
                dataGridView1.Columns[7].Visible = false;
                dataGridView1.Columns[8].Visible = false;
                dataGridView1.Columns[9].Visible = false;
                dataGridView1.Columns[10].Visible = false;
                dataGridView1.Columns[11].Visible = false;
                dataGridView1.Columns[12].Visible = false;
                dataGridView1.Columns[13].Visible = false;
                */
                combofull = false;
                cmbDepartment.DataSource = dto.Departments;
                cmbDepartment.DisplayMember = "DepartmentName";
                cmbDepartment.ValueMember = "ID";

                cmbPosition.DataSource = dto.Positions;
                cmbPosition.DisplayMember = "PositionName";
                cmbPosition.ValueMember = "ID";
                cmbDepartment.SelectedIndex = -1;
                cmbPosition.SelectedIndex = -1;

                if (dto.Departments.Count > 0)
                    combofull = true;
            }

            cmbMonth.DataSource = dto.Months;
            cmbMonth.DisplayMember = "MonthName";
            cmbMonth.ValueMember = "ID";
            cmbMonth.SelectedIndex = -1;

            if (isUpdate)
            {
                panel1.Hide();
                txtName.Text = detail.Name;
                txtSalary.Text = detail.SalaryAmount.ToString();
                txtSurname.Text = detail.Surname;
                txtYear.Text = detail.SalaryYear.ToString();
                cmbMonth.SelectedValue = detail.MonthID;
            }
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtUserNo.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtSurname.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtYear.Text = DateTime.Today.Year.ToString();
            txtSalary.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            salary.EmployeeID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
            oldsalary = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value);

        }
        
        SALARY salary = new SALARY();
        int oldsalary = 0;
        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (cmbMonth.SelectedIndex == -1)
                MessageBox.Show("Please select a month");
            else if (txtSalary.Text.Trim() == "")
                MessageBox.Show("Please fill the salary");
            else if (txtUserNo.Text == "")
                MessageBox.Show("Please select an employee from table");
            else
            {
                bool control = false;
                if (!isUpdate)
                {

                    if (txtYear.Text.Trim() == "")
                        MessageBox.Show("Please fill the year");
                    else
                    {
                        salary.Year = Convert.ToInt32(txtYear.Text);
                        salary.MonthID = Convert.ToInt32(cmbMonth.SelectedValue);
                        salary.Amount = Convert.ToInt32(txtSalary.Text);
                        if(salary.Amount > oldsalary)
                        {
                            control = true;
                        }
                        SalaryBLL.AddSalary(salary, control);
                        MessageBox.Show("Salary added");
                        cmbMonth.SelectedIndex = -1;
                        salary = new SALARY();
                    }
                }

                else
                {
                    DialogResult result = MessageBox.Show("Are you sure?", "Warning!!", MessageBoxButtons.YesNo);
                    if (DialogResult.Yes == result)
                    {
                        SALARY salary = new SALARY();
                        salary.ID = detail.SalaryID;
                        salary.EmployeeID = detail.EmployeeID;
                        salary.Year = Convert.ToInt32(txtYear.Text);
                        salary.MonthID = Convert.ToInt32(cmbMonth.SelectedValue);
                        salary.Amount = Convert.ToInt32(txtSalary.Text);
                        
                        if(salary.Amount > detail.OldSalary)
                        {
                            control = true;
                        }
                        SalaryBLL.UpdateSalary(salary, control);
                        MessageBox.Show("Salary was updated");
                        this.Close();
                    }
                }
            }
        }
    }
}