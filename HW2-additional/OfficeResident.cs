using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_additional
{
    class OfficeResident : Employee
    {
        public double Salary;

        public OfficeResident (string name, int age, double salary) : base(name, age)
        {
            this.Salary = salary;
        }

        public override void CalcIncome()
        {
            AvMonthSalary = Salary;
        }
    }
}
