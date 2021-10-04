using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2_additional
{
    abstract class Employee : IComparable<Employee>
    {
        protected string Name;
        protected int Age;
        protected double AvMonthSalary;

        public Employee(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public abstract void CalcIncome();

        public int CompareTo(Employee other)
        {
            return (int)(this.AvMonthSalary - other.AvMonthSalary);
        }

        public override string ToString()
        {
            return new string($"{Name} в возрасте {Age} имеет среднемесячный заработок в размере {AvMonthSalary:f2}");
        }
    }
}
