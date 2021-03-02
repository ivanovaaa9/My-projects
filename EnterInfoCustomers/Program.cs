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
            client client1 = new client();
            Console.WriteLine("Enter a customer name: ");
            client1.Name=Console.ReadLine();
            Console.WriteLine("Enter a customer address: ");
            client1.Address=Console.ReadLine();
            Console.WriteLine("Enter a customer number: ");
            client1.Pnumber=Console.ReadLine();

            Console.WriteLine("Customer name:" + client1.Name + " ;Customer address:" + client1.Address + " ;Customer phone number:" + client1.Pnumber);
          








        }
       
        }
    }

