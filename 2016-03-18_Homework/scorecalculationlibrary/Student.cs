using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScoreCalculationLibrary
{
    public class Student
    {
        //private string name;

        public string Name { get; set; }

        public Grade[] grades;

        public Student()
        {
        }

        public Student(string name, double chinese, double english, double math)
        {
            this.Name = name;

            this.grades = new Grade[3]
            {
                new Grade { subject = "國文" },
                new Grade { subject = "英文"},
                new Grade { subject = "數學"}
            };
            this.grades[0].Value = chinese;
            this.grades[1].Value = english;
            this.grades[2].Value = math;
        }

        public double TotalGrade
        {
            get
            {
                double total = 0.0;
                for (int index = 0; index < this.grades.Length; index++)
                {
                    total = total + grades[index].Value;
                }
                return total;
            }
        }

        public override string ToString()
        {
            string result = string.Empty;
            result += string.Format("學生:{0}\n", this.Name);
            result += string.Format("{0}\n", this.grades[0]);
            result += string.Format("{0}\n", this.grades[1]);
            result += string.Format("{0}\n", this.grades[2]);
            result += string.Format("總分:{0}", this.TotalGrade);
            return result;
        }

        public void aStudent()
        {
            Student student = new Student(); //{ Name = "Resnick" };
            string name = string.Empty;
            int chinese = 0;
            int english = 0;
            int math = 0;
            Console.Write("請輸入姓名:");
            name = Console.ReadLine();

            do
            {
                Console.Write("請輸入國文成績:");
            } while (!int.TryParse(Console.ReadLine(), out chinese));

            do
            {
                Console.Write("請輸入英文成績:");
            } while (!int.TryParse(Console.ReadLine(), out english));

            do
            {
                Console.Write("請輸入數學成績:");
            } while (!int.TryParse(Console.ReadLine(), out math));

            //if (!int.TryParse(Console.ReadLine(), out chinese))
            //{
            //    Console.WriteLine("輸入錯誤，請重新輸入");
            //}

            student = new Student(name, chinese, english, math);
            //student.grades[0].value = 1000;

            Console.WriteLine(student);
        }
    }
}