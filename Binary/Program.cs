using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string decimal1;
            string binary1;

            Console.WriteLine("Input a Number : ");
            decimal1 = Console.ReadLine();

            int num = Convert.ToInt32(decimal1);
            binary1 = "";
            while (num > 1)
            {
                int remainder = num % 2;
                binary1 = Convert.ToString(remainder) + binary1;
                num /= 2;
            }
            binary1= Convert.ToString(num) + binary1;
            Console.WriteLine("Binary: {0}", binary1);
            Console.ReadKey();
        }

    }
}

