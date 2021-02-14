using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius: ");
            int radius = int.Parse(Console.ReadLine());

            double parameterCircle = Math.PI * radius * 2;
            double areaCircle = Math.PI * radius * radius;

            Console.WriteLine("The parameter of the circle is: " + parameterCircle +
                ", the area of the circle is: " + areaCircle);
            Console.ReadKey();

        }
    }
}
