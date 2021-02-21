using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app5
{
    class Program
    {
        static void Main(string[] args)
        {

            int i, j;
            int[,] array1 = new int[3, 3];

            Console.WriteLine("Input elements in the matrix :");
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    Console.WriteLine("element - [{0},{1}] : ", i, j);
                    array1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.Write("The matrix is : ");
            for (i = 0; i < 3; i++)
            {
                Console.WriteLine(" ");
                for (j = 0; j < 3; j++)
                    Console.WriteLine("{0}", array1[i, j]);
            }
            Console.WriteLine(" ");
            Console.ReadKey();
        }
    }

}




