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
            Console.Write("Enter input: ");
            char[] strippedChars = Console
                .ReadLine().ToCharArray().Where(c => Char.IsLetter(c) || c == ' ').ToArray();
            Stack<String> wordsStack = new Stack<String>(new string(strippedChars).Split(' '));
            int wordsCount = wordsStack.Count;
            for (int i = 0; i < wordsCount; i++)
            {
                string poped = wordsStack.Pop();
                Console.Write(poped + " ");
            }

            Console.WriteLine();
        }
    }
}
