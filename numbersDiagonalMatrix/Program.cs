using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, sum = 0, n;
            int[,] arr1 = new int[2, 2];
            Console.WriteLine("Lenght of an array:");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; i++)
            {
                for (j = 0; j < n; j++)
                {
                    Console.WriteLine("element - [{0}],[{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    if (i == j) sum = sum + arr1[i, j];
                }
            }
            Console.WriteLine("The matrix is :");
            for (i = 0; i < n; i++)
                
            {
                for (j = 0; j < n; j++)
                    Console.Write("{0} ", arr1[i, j]);
                Console.WriteLine(" ");
            }
            Console.WriteLine("Addition of the right Diagonal elements is :{0}", sum);
            Console.ReadKey();
        }
    }

}
    

