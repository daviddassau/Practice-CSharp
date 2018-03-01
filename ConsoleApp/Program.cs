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
            var fruitList = new List<string>();

            fruitList.Add("Apple");
            fruitList.Add("Orange");
            fruitList.Add("Grapes");

            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }

            Console.ReadLine();
        }
    }
}
