using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10] { 2, 4, 6, 8, 10, 12, 14, 16,18,20};
          
            Console.WriteLine("Elements in array are: ");
            for(int i = 0; i <10; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
            Console.Write(" ");
            Console.ReadKey();
            
        }
        
    }
}
