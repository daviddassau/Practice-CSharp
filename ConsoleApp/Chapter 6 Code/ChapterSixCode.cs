//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp.Chapter_6_Code
//{
//    class ChapterSixCode
//    {
//        var inventory = new Dictionary<string, double>();

//        inventory.Add("Figs", 56);
//            inventory.Add("Apples", 23);
//            inventory.Add("Oranges", 12);

//            var keys = inventory.Keys;

//        Console.WriteLine($"Number of items: {keys.Count}");

//            foreach (var key in keys)
//            {
//                Console.WriteLine($"{key}: {inventory[key]}"); // this will display the items in the dictionary as they're listed in the dictionary
//            }

//    string[] keysArray = keys.ToArray();
//    Array.Sort(keysArray);

//            foreach (var key in keysArray)
//            {
//                Console.WriteLine($"{key}: {inventory[key]}"); // this will display the items in the dictionary in alphabetical order
//            }

//// this will test what's passed in ("Figs") and see if it's true or false
//double value;
//            if (inventory.TryGetValue("Figs", out value))
//            {
//                Console.WriteLine($"Figs inventory: {value}");
//            }
//            else
//            {
//                Console.WriteLine("Figs inventory not available");
//            }
//    }
//}
