using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            String input = Console.ReadLine();
            String vowels = "aeiou";

            int vowelsCount = input.ToCharArray().Count(c => vowels.IndexOf(c.ToString(), 0) >= 0);
            Console.WriteLine("Vowels Count: {0}", vowelsCount);
            Console.WriteLine("Consonants Count: {0}", input.Replace(" ", string.Empty).Length - vowelsCount);
        }
    }
}
