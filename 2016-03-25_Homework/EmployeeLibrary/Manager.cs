using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLibrary
{
    public class Manager : Sales
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

        public Manager(string id, string name, int baseSalary, int performance, int teamBouns)
            : base(id, name, baseSalary, performance)
        {
            this.TeamBouns = teamBouns;
        }

        public Manager(string id, string name, string baseSalary, string performance, string teamBouns)
            : this(id, name, int.Parse(baseSalary), int.Parse(performance), int.Parse(teamBouns))
        { }

        public override int Performance
        {
            get
            {
                return this.Performance;
            }

            set
            {
                if (value < 0)
                    base.performance = 0;
                else
                    base.performance = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() + string.Format("\n業績:{0}\nTeam奬金:{0}", this.Performance, this.TeamBouns);
        }
    }
}