using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0, num1, sum;

            Console.Write("Enter a number: ");
            num1 = int.Parse(Console.ReadLine());
            while (counter <= 10)
            {
                sum = num1 * counter;

                Console.WriteLine("{0} x {1}= {2} ", num1, counter, sum);
                counter++;
            }
            Console.ReadKey();
        }
    }
}
