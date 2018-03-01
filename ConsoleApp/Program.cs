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
            string[] fruit = { "Apples", "Oranges", "Grapes" };
            foreach (var item in fruit)
            {
                Console.WriteLine(item);
            }

            string[] names = new string[3];
            names[0] = "Joe";
            names[1] = "Mary";
            names[2] = "Martha";
            


            Console.ReadLine();
        }
    }
}
