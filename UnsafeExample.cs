using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class UnsafeExample
    {
        public unsafe void Run() //int the .csproj enable AllowUnsafeBlocks
        {
            int snoopDog = 420;
            int* pointer = &snoopDog;
            Console.WriteLine("The int value is "+*pointer);
            Console.WriteLine("The string value is "+pointer->ToString());
            Console.WriteLine("The address value is "+(int)pointer);

        }
    }
}
