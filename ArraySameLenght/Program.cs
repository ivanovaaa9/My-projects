using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[2] { 1, 2 };
            int[] array2 = new int[2] { 3, 2 };
            Console.WriteLine(" Length of a first array = 2, first element = 1 and second element =2");
            Console.WriteLine(" Length of a second array =2, first element= 3, second element = 2. ");

            if(array == array2)
            {
                Console.WriteLine("Arrays are the same with the same lenght.");

            }
            else
            {
                Console.WriteLine("The arrays are not equal but they have the same length.");

            }
            Console.ReadKey();

        }
    }
}
