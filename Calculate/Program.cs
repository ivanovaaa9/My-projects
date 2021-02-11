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
            int x = 1;
            int y = 2;
            int z = 3;
            int value1 = (x + y) * z;
            int value2 = x * y + y * z;
            Console.WriteLine("Result: (x + y)*z = " + value1
                + ", x*y + y*z = " + value2);
            Console.ReadKey();

        }
    }
}
