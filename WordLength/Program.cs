using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4._4
{
    class Program
    {
        static void Main(string[] args)
        {
            string words = Console.ReadLine().ToLower().Replace(" ","");
            int consonants = 0;
            int vowels = 0;
            int space = 0;
            for(int i = 0; i < words.Length; i++)
            {
                if (words[i] == 'a' || words[i] == 'e' || words[i] == 'i' || words[i] == 'o' || words[i] == 'u')
                {
                    vowels++;
                
                }else{
                    consonants++;
                }

            }
            Console.WriteLine("Total number of vowels:{0} ", vowels);
            Console.WriteLine("Total number of consonatnts:{0} ", consonants);
            Console.ReadKey();

        }
          
        }
    }

