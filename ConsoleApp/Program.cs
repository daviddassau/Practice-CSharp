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

            // Sort will sort the items in alphabetical order
            fruitList.Sort();
            foreach (var item in fruitList)
            {
                Console.WriteLine(item);
            }

            ReportOnGrapes(fruitList);

            Console.ReadLine();
        }

        static void ReportOnGrapes(List<string> items)
        {
            string grapeReport = 
                items.Contains("Grapes", StringComparer.OrdinalIgnoreCase) ? 
                "Yes there are grapes" :
                "No, there are no grapes";
            Console.WriteLine(grapeReport);
        }
    }
}
