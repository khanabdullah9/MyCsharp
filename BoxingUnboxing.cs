using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class BoxingUnboxing
    {
        public void Run() 
        {
            int n = 2022;
            Object obj = n;
            Console.WriteLine($"Boxing: Converting value type: {n} to reference type: {obj}");
            Console.WriteLine($"Unboxing: Converting reference type {obj} to value type {(int)obj}");

            Console.WriteLine("Type 'y' for definition");
            var input = Console.ReadLine();
            if (input.Equals("y"))
            {
                Console.WriteLine("The process of converting a Value Type variable (char, int etc.) to a Reference Type variable (object) is called Boxing.");
                Console.WriteLine("The process of converting a Reference Type variable into a Value Type variable is known as Unboxing.");
            }
            else 
            {
                Console.WriteLine("OK thank you");
            }
        }
    }
}
