using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3New
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Matrix size = ");
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];
            Console.Write("From = ");
            int from = int.Parse(Console.ReadLine());
            Console.Write("To = ");
            int to = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    matrix[j, i] = from++;
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }

                Console.WriteLine();
                Console.ReadKey();

            }


        }
    }
}

