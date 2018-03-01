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



            //string input = Console.ReadLine();

            //if (input.Equals("Hello", StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("You said Hello");
            //}
            //else if (input.Equals("Goodbye", StringComparison.OrdinalIgnoreCase))
            //{
            //    Console.WriteLine("You said Goodbye");
            //}
            //else
            //{
            //    Console.WriteLine("You said something else.");
            //}



            //Console.Write("Enter an operation: + - * / ");
            //string operation = Console.ReadLine();

            //switch (operation)
            //{
            //    case "+":
            //        Console.WriteLine("You chose to add");
            //        break;

            //    case "-":
            //        Console.WriteLine("You chose to subtract");
            //        break;

            //    case "*":
            //        Console.WriteLine("You chose to multiply");
            //        break;

            //    case "/":
            //        Console.WriteLine("You chose to divide");
            //        break;

            //    default:
            //        Console.WriteLine("No such operation");
            //        break;
            //}



            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("Number: " + i);
            }

            string[] fruit = { "Apples", "Oranges", "Grapes" };
            for (int i = 0; i < fruit.Length; i++)
            {
                Console.WriteLine(fruit[i]);
            }

            Console.ReadLine();
        }
    }
}
