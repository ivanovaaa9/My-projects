using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sentence:");
           string letters = Console.ReadLine();
            string[] sentence = letters.Split(' ');
            int new1 = sentence.Length - 1;
            
            
            Console.WriteLine("The sentence in reverse order:");
            for(int i = letters.Length-1; i >= 0; i--)
            {
                Console.Write(sentence[new1] + "" + ' ');
                new1--;
                
            }
            Console.ReadKey();
        }
           
                
        }
    }
    

