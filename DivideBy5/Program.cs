using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number: ");
            int num1 = int.Parse(Console.ReadLine());

            if (num1 % 5 == 0)
            {
                Console.WriteLine("Number " + num1 + " is divisible by 5.");

            }
            else
            {
                Console.WriteLine("Number " + num1 + " is not divisible by 5.");
            }
            Console.ReadKey();

        }
    }
}
