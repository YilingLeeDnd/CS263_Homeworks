using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Employee employee = new Employee();
            string Name = string.Empty;
            int baseSalary = 0;
            int bouns = 0;
            Console.Write("請輸入姓名:");
            Name = Console.ReadLine();
            do
            {
                Console.Write("請輸入底薪:");
            } while (!int.TryParse(Console.ReadLine(), out baseSalary));
            do
            {
                Console.Write("請輸入Bouns:");
            } while (!int.TryParse(Console.ReadLine(), out bouns));
            employee.BaseSalary = baseSalary;
            employee.Bonus = bouns;
            Console.WriteLine(employee.Salary);
            Console.WriteLine(employee);
        }
    }
}