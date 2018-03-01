using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Chapter_6_Code
{
    public class DefiningClassWithStaticMethod
    {
        public void Fruit()
        {
            string[] fruit = { "Apples", "Oranges", "Grapes" };
            for (int i = 0; i < fruit.Length; i++)
            {
                Console.WriteLine(fruit[i]);
            }
        }
    }
}
