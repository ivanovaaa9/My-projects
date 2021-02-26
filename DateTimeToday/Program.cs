using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Year: {0}", now.Year);
            Console.WriteLine("Month: {0}", now.Month);
            Console.WriteLine("Day: {0}", now.Day);
            Console.WriteLine("Hour: {0}", now.Hour);
            Console.WriteLine("Minutes: {0}", now.Minute);
            Console.WriteLine("Seconds: {0}", now.Second);
        }
    }
}
