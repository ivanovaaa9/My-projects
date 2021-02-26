using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            String sentence1 = Console.ReadLine();
            String sentence2 = Console.ReadLine();
            bool areEqual = true;
            if(sentence1.Length != sentence2.Length)
            {
                areEqual = false;
            } else
            {
                areEqual = sentence1.CompareTo(sentence2) == 0;
            }

            if(areEqual)
            {
                Console.WriteLine("The sentences are equal.");
            } else
            {
                Console.WriteLine("The sentences are not equal.");
            }
        }
    }
}
