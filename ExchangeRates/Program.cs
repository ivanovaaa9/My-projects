using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15114269
{
    class Program
    {
        private static object valuenew;

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a value: ");
            int value = int.Parse(Console.ReadLine());
            
            double usd = 1.81;
            double euro = 1.96;
            double bgn;
            double usd1 = value * 1.81;
            double euro1 = value * 1.96;
            string valuesnew;

            int times = 0;
            
                List<string> list = new List<string>();
                Console.WriteLine("BGN to usd or euro: ");
                string choice = Console.ReadLine();
                if (choice.Equals("usd"))
                {
                    Console.WriteLine("The value is: " + usd1);

                }
                else if (choice.Equals("euro"))
                {
                    Console.WriteLine("The value is:" + euro1);
                }

            Console.WriteLine("How many times to iterate: ");
            times = int.Parse(Console.ReadLine());
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine("1st time: ", (i + 1));
                Console.WriteLine("BGN to usd or euro: ");
                string choice1 = Console.ReadLine();


                list.Add(Console.ReadLine());
                if (choice1.Equals("usd"))
                {

                    Console.WriteLine("The value is: " + usd1);
                    Console.WriteLine("Enter a value: ");

                }
                else if (choice1.Equals("euro"))
                {
                    Console.WriteLine("The value is:" + euro1);
                    Console.WriteLine("Enter a value: ");
                }
                if (choice1.Equals(valuenew))
                {
                    Console.WriteLine("Error, you should enter a number: ");
                    Console.WriteLine();
                }
            }
            string myDocDir = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filename = Console.ReadLine();
            string path = myDocDir + @"\" + 15114269 + ".txt";

            
                }

}

        
        }
       
        
    
    

