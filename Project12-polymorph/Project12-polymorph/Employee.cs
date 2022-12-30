﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project12_polymorph
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public double EmployeeSalary { get; set; }
        public void SetValues(int ID)
        {
            EmployeeID = ID;
        }
        public void SetValues(int ID, string EmployeeName)
        {
            EmployeeID = ID;
            Name = EmployeeName;
        }
        public void SetValues(int ID, string EmployeeName, double Salary)
        {
            EmployeeID = ID;
            Name = EmployeeName;
            EmployeeSalary = Salary;
        }
    }
}
