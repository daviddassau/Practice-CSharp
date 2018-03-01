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
            var inventory = new Dictionary<string, double>();

            inventory.Add("Figs", 56);
            inventory.Add("Apples", 23);
            inventory.Add("Oranges", 12);

            Console.ReadLine();
        }
    }
}
