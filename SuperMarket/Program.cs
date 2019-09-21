using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = string.Empty;
            List<string> items = new List<string>();

            Console.WriteLine("Please scan item");
            choice = Console.ReadLine().ToLower();
            if (choice != "a" && choice != "b" && choice != "c" && choice != "d")
            {
                Console.WriteLine("Scanned item is not registered");
            }
            else { items.Add(choice); }

            do
            {
                Console.WriteLine("Please scan next item or press 0 if you are done");
                choice = Console.ReadLine().ToLower();
                if (choice != "0")
                {
                    if (choice != "a" && choice != "b" && choice != "c" && choice != "d")
                    {
                        Console.WriteLine("Scanned item is not registered");
                    }
                    else { items.Add(choice); }
                }

            } while (choice != "0");


            Checkout<List<string>> c = new Checkout<List<string>>(items);

            var total = c.Total() * 0.01;
            Console.WriteLine("Total Cost - £{0}", total.ToString());
        }
    }
}
