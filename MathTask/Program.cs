using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_1 = int.Parse(Console.ReadLine());
            int number_2 = int.Parse(Console.ReadLine());
            int adding = number_1 + number_2;
            int subtracting = number_1 - number_2;
            int multiplying = number_1 * number_2;
            int dividing = number_1 / number_2;
            Console.Write("Result: adding = " + adding
                + ", subtracting = " + subtracting
                + ", multiplying = " + multiplying
                + ", dividing = " + dividing);
            Console.ReadKey();


        }
    }
}
