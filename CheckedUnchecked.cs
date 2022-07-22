using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class CheckedUnchecked
    {
        public static void Syntax() 
        {
            checked
            {
                uint max = uint.MaxValue;
                max++;
                Console.WriteLine(max);
            }

            uint max2 = uint.MaxValue;
            max2++;
            Console.WriteLine(max2);
        }
    }
}
