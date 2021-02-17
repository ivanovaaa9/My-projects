using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a random four digit number: ");
            int number = int.Parse(Console.ReadLine());
            
            int a = number / 1000;
            int b = (number - a * 1000) / 100;
            int c = (number - (a * 1000 + b * 100)) / 10;
            int d = (number - (a * 1000 + b * 100 + c * 10));
            
            int sum = a + b + c + d;
            
            Console.WriteLine("The sum of the four digits is: " + sum);
            Console.WriteLine("Digits in reverse order: {0}{1}{2}{3}", d, c, b, a);
            Console.WriteLine("Last digit in first place: {0}{1}{2}{3}", d, a, b, c);
            Console.WriteLine("Switched 2nd and 3rd positions: {0}{1}{2}{3}", a, c, b, d);
            Console.ReadKey();

        }
    }
}
