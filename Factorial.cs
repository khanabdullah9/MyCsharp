using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class Factorial
    {
        public static int Of(int n) 
        {
            if (n == 1) 
            {
                return n;
            }
            return n * Of(n-1);
        }
    }
}
