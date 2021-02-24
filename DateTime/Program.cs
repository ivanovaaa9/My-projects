using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app2._4
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime datet = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("{0}", datet.Year);
            Console.WriteLine("{0}", datet.Month);
            Console.WriteLine("{0}", datet.Day);
            Console.WriteLine("{0}", datet.Hour);
            Console.WriteLine("{0}", datet.Minute);
            Console.WriteLine("{0}", datet.Second);
            Console.ReadKey();

        }
       
       
    }
}
