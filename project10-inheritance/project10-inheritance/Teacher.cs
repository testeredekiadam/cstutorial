using System;
using System.Collections.Generic;
using System.Text;

namespace project10_inheritance
{
    class Teacher:Employee
    {
        public string Branch { get; set; }

        public void FindSalary()
        {
            Salary = 2000;
        }

        public void SetValues2()
        {
            Position = "Teacher";
            Branch = "Math";
        }
    }
}
