using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Manager : Employee
    {
        private int teamBouns;

        public int TeamBouns
        {
            get { return this.teamBouns; }
            set
            {
                if (value < 0)
                    this.teamBouns = 0;
                else
                    this.teamBouns = value;
            }
        }

        public Manager(string id, string name, int baseSalary, int teamBouns)
            : base(id, name, baseSalary)
        {
            this.TeamBouns = teamBouns;
        }

        public Manager(string id, string name, string baseSalary, string teamBouns)
            : this(id, name, int.Parse(baseSalary), int.Parse(teamBouns))
        { }

        public override double BaseSalary
        {
            get
            {
                return base.BaseSalary;
            }
            set
            {
                base.baseSalary = 22000;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\nTeam奬金:{0}", this.TeamBouns);
        }
    }
}