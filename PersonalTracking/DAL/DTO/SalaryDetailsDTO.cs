﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DTO
{
    public class SalaryDetailsDTO
    {
        public int EmployeeID { get; set; }
        public string Password { get; set; }
        public int UserNo { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Salary { get; set; }
        public string DepartmentName { get; set; }
        public string PositionName { get; set; }
        public string MonthName { get; set; }
        public int SalaryYear { get; set; }
        public int MonthID { get; set; }
        public int SalaryAmount { get; set; }
        public int SalaryID { get; set; }
        public int OldSalary { get; set; }
        public int DepartmentID { get; set; }
        public int PositionID { get; set; }
    }
}
