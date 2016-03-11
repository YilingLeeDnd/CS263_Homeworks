using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            byte number0 = 254;
            byte number1 = (byte)(number0 + 1);
            //原number0 + 1程式判定為int(32位元)，所以把number0 + 1宣告成byte(8位元)
            Console.WriteLine(number0);
            Console.WriteLine(number1);
        }
    }
}