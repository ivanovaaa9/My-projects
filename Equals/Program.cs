using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence1 = Console.ReadLine();
            string sentence2 = Console.ReadLine();
            if (sentence1.Equals(sentence2))
            {
                Console.WriteLine("They are the same.");
            }
            else
            {
                Console.WriteLine("The sentences are not equal");
            }
            Console.ReadKey();

        }
    }
}
