using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class TimesTable
    {
        public static void Print(int number, int upto) 
        {
            for (int i=1;i<=upto;++i)
            {
                Console.WriteLine($"{number} x {i} = {number*i}");
            }
        }
    }
}
