using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student someone =
                new Student
                {
                    name = "小李",
                    Contact = new Contact
                    {
                        email = "lee@gmail.com",
                        phone = "0910123456"
                    }
                };
            Console.WriteLine(someone.name);
            Console.WriteLine(someone.Contact.email);
            Console.WriteLine(someone.Contact.phone);
        }
    }
}