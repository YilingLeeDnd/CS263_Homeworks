using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Random random = new Random();
            for (int i = 100; i <= 999; i++)
            {
            }
            do
            {
                Console.Write("您猜的數字為(3位數的數字)：");
                if (random.Next(100, 1000) == int.Parse(Console.ReadLine()))
                    Console.WriteLine("賓果");
                else
                    Console.WriteLine("猜錯了 >\"<");
                Console.Write("再猜一次嗎？(Y/N)");
            } while (Console.ReadLine() == "Y");
        }
    }
}