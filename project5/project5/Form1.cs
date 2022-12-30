using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<int> numberList = new List<int>();
        List<string> textList = new List<string>();
        List<Employee> employeeList = new List<Employee>();
        public List<Employee> fillList()
        {
            employeeList.Clear();
            Employee employee1 = new Employee();
            employee1.ID = 1;
            employee1.Name = "Firat";
            employee1.Surname = "Erkol";
            employeeList.Add(employee1);

            Employee employee2 = new Employee();
            employee2.ID = 2;
            employee2.Name = "Clark";
            employee2.Surname = "Kent";
            employeeList.Add(employee2);

            Employee employee3 = new Employee();
            employee3.ID = 3;
            employee3.Name = "Indiana";
            employee3.Surname = "Jones";
            employeeList.Add(employee3);
            return employeeList;
        }

        List<Days> comboList = new List<Days>();


        private void Form1_Load(object sender, EventArgs e)
        {
            Days day1 = new Days();
            day1.ID = 1;
            day1.textValue = "Sunday";
            comboList.Add(day1);
            Days day2 = new Days();
            day2.ID = 2;
            day2.textValue = "Monday";
            comboList.Add(day2);
            Days day3 = new Days();
            day3.ID = 3;
            day3.textValue = "Tuesday";
            comboList.Add(day3);
            Days day4 = new Days();
            day4.ID = 4;
            day4.textValue = "Wednesday";
            comboList.Add(day4);
            Days day5 = new Days();
            day5.ID = 5;
            day5.textValue = "Thursday";
            comboList.Add(day5);
            Days day6 = new Days();
            day6.ID = 6;
            day6.textValue = "Friday";
            comboList.Add(day6);
            comboList.Add(new Days() { ID = 7, textValue = "Saturday" });
            cmbDays.DataSource = comboList;
            cmbDays.ValueMember = "ID";
            cmbDays.DisplayMember = "textValue";
            dayList.DataSource = comboList;
        }

        private void btnFillList_Click(object sender, EventArgs e)
        {
            fillList();
            foreach(var item in employeeList)
            {
                txtNumber.Text += item.ID + " " + item.Name +" "+ item.Surname + Environment.NewLine;
            }
        }

        private void cmbDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(cmbDays.SelectedValue.ToString());
        }
    }
}
