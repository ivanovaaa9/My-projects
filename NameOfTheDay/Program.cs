using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app4._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            
            DateTime date = new DateTime(2017, 3, 3);
            Console.WriteLine("day=" + year + ", month = 3" + ", year= 2017");
            Console.WriteLine(date.DayOfWeek);
            
            

            Console.ReadKey();
        }
        

    }
    }

