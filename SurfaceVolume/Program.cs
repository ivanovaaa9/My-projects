using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter radius:");
            int radius = int.Parse(Console.ReadLine());

            double surface = 4 * Math.PI * radius * radius;
            double volume = (3 * Math.PI * radius * radius * radius) / 4;
            Console.WriteLine("Surface: " + surface);
            Console.WriteLine("Volume: " + volume);
            Console.ReadKey();

        }
    }
}
