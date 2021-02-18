using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            float distance, timesec, kph, mps, mph, hour, sec, min;
            Console.WriteLine("Meters: ");
            distance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours: ");
            hour = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Minutes: ");
            min = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Seconds: ");
            sec = Convert.ToInt32(Console.ReadLine());
            timesec = (hour * 3600) + (min * 60) + sec;
            mps = distance / timesec;
            kph = (distance / 1000.0f) / (timesec / 3600.0f);
            mph = kph / 1.60344f;
            Console.WriteLine("The Mile Per Second is={0}", mps);
            Console.WriteLine("the kilometer per hour is={0}", kph);
            Console.WriteLine("The Mile per Hour is={0}", mph);
            Console.ReadLine();

        }
    }
}
