using System;
using System.Collections.Generic;
using System.Text;

namespace Project12_polymorph
{
    class Teacher2 : Employee2
    {
        public virtual string SetValues(int ID, string EmployeeName, double Salary)
        {
            EmployeeID = ID;
            Name = EmployeeName;
            EmployeeSalary = Salary;
            EmployeePosition = "Manager";

            string text = "Employee ID: " + EmployeeID + Environment.NewLine;
            text += "Employee Name: " + Name + Environment.NewLine;
            text += "Employee Salary: " + EmployeeSalary + Environment.NewLine;
            text += "Employee Position: " + EmployeePosition + Environment.NewLine;
            return text;
        }
    }
}
