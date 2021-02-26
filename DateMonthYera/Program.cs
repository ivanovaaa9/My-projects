using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Day = ");
            int day = int.Parse(Console.ReadLine());
            Console.Write("Month = ");
            int month = int.Parse(Console.ReadLine());
            Console.Write("Year = ");
            int year = int.Parse(Console.ReadLine());
            DateTime givenDate = new DateTime(year, month, day);
            Console.WriteLine("Result: {0}", givenDate.DayOfWeek);
        }
    }
}
