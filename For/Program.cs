using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number_1 =int.Parse(Console.ReadLine());
            Console.WriteLine("Number: " + number_1);

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(number_1 * i);
                
            }

            Console.ReadKey();

        }
    }
}
