using System;
using System.Collections.Generic;
using System.Text;

namespace project10_inheritance
{
    class Employee:Human
    {
        protected string Position { get; set; }
        protected double Salary { get; set; }

        public void SetValues()
        {
            Name = "Firat";
            ID = 1;
            Gender = 'M';
            Age = 29;
        }
    }
}
