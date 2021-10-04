using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_additional
{
    class Freelancer : Employee
    {
        public double Rate;

        public Freelancer (string name, int age, double rate) : base (name, age)
        {
            this.Rate = rate;
        }

        public override void CalcIncome()
        {            
            AvMonthSalary = 20.8 * 8 * Rate;
        }
    }
}
