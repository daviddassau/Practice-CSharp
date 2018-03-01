using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //string input = Console.ReadLine();
            //Console.WriteLine("You entered: " + input);



            string input = Console.ReadLine();

            if (input.Equals("Hello", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You said Hello");
            }
            else if (input.Equals("Goodbye", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("You said Goodbye");
            }
            else
            {
                Console.WriteLine("You said something else.");
            }

            Console.ReadLine();
        }
    }
}
