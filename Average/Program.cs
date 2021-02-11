using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    class Program
    {
        static void Main(string[] args)
        { int number_1 = 10;
            int number_2 = 15;
            int number_3 = 25;
            int number_4 = 10;

            int avg = (number_1 + number_2 + number_3 + number_4) / 4;
            Console.WriteLine("Result: average" +
                " value = " + avg);
            Console.ReadKey();

        }
    }
}
