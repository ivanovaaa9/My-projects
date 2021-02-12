using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app5
{
    class Program
    {
        static void Main(string[] args)
        { int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: " + number);
            if (number % 2 == 0)
            {
                Console.WriteLine("even");
            }
            else
            {

                Console.WriteLine("odd");
            }
            Console.ReadKey();

        }
    }
}
