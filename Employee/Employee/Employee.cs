using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class Employee
    {
        public string Name { get; set; }
        private double value;

        public double Value
        {
            get
            {
                return this.value;
            }
        }

        private int baseSalary;

        public int BaseSalary
        {
            get { return baseSalary; }
            set
            {
                if (value < 0)

                    this.baseSalary = 0;
                else if (value > 22000)
                    this.baseSalary = 22000;
                else
                    this.baseSalary = value;
            }
        }

        private int bonus;

        public int Bonus
        {
            get { return bonus; }

            set { bonus = baseSalary < 0 ? 0 : baseSalary; }
        }

        public int salary;

        public int Salary
        {
            get
            {
                this.salary = this.BaseSalary + this.Bonus;
                return this.salary;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("底薪:{0}\n", this.baseSalary);
            result += string.Format("Bouns:{0}\n", this.bonus);
            result += string.Format("薪水:{0}", this.salary);
            return result;
        }
    }
}

//benefit = value < 0 ? 0 : value // benefit小於0給0，不然就給value