using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("How many books: ");
            count = int.Parse(Console.ReadLine());

            List<string> books = new List<string>();

            for (int j = 0; j < count; j++) {
                Console.WriteLine("book: " + (j + 1));
                books.Add(Console.ReadLine());
            }
            books.Reverse();
            Console.WriteLine("The books in reverse order: ");
            foreach (String t in books) {
                Console.WriteLine(t);
                
            }
            books.Sort();
            Console.WriteLine("Books in alphabetical order");
            foreach(String b in books)
            {
                Console.WriteLine(b);
            }
            Console.WriteLine("Choose to delete a book or close the program?");
            int option = int.Parse(Console.ReadLine());
            if (option==1)
            {
                Console.WriteLine("Which one?");
                string title = Console.ReadLine();
               books.Remove(title);
                foreach (String b in books)
                {
                    Console.WriteLine(b);
                }
            }
            else if (option==2)
                {
                Console.WriteLine("End");
            }


           
            Console.ReadKey();
        }
       
    }
}
