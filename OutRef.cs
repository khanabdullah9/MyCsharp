using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class OutRef
    {
        public void Run(out int number, ref int age)
        {
            number = 44;
            Console.WriteLine($"The age is {age} and the number is {number}");
        }
    }
}
