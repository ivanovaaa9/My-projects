using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            int[] array = new int[3] { 1, 2, 3 };
            Console.WriteLine("Elements:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
            Console.WriteLine("Values stored into reverse orders: ");
            for (int i = n - 1; i >= 0; i--) {

              
                    Console.WriteLine("{0}", array[i]);

            }
            Console.ReadKey();

        }
        
        }
    }

