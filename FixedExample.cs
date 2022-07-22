using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class FixedExample
    {
        private string text = "Khan";
        public unsafe void Run() 
        {
            fixed (char* pointer = text) 
            {
                var name = string.Empty;
                char* ptr = pointer;
                while (*ptr != '\0')
                {
                    name += *ptr;
                    ptr++;
                }
                Console.WriteLine($"The name is: {name}");
            }
        }
    }
}
