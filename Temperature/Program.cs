using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter value in Celsius:");
            int c = int.Parse(Console.ReadLine());
            int k = (c + 273);
            int f = ((c * 18) / 10 + 32);
            Console.WriteLine("In Kelvin: " + k + ", in Fahrenheit: "
                + f);
            Console.ReadKey();

        }
    }
}
