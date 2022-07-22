using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class StackAllocExample
    {
        public void Run()
        {
            Span<int> numbers = stackalloc int[] { 4, 2, 0 };//FIrst of all why?
            var result = string.Empty;
            foreach (var num in numbers) 
            {
                result = result + num;
            }
            Console.WriteLine(result);
        }
    }
}
