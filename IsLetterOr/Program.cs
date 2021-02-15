using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            char symb;

            Console.Write("Input a symbol: ");
            symb = char.Parse(Console.ReadLine());

            if ((symb == 'a') || (symb == 'e') || (symb == 'i') ||
                    (symb == 'o') || (symb == 'u'))
            {
                Console.WriteLine("It's a vowel.");
            }
            else if ((symb >= '0') && (symb <= '9'))
            {
                Console.WriteLine("It's a digit.");
            }
            else
            {
                Console.WriteLine("It's another symbol.");
            }

            Console.ReadKey();
        }
    }
}


    

