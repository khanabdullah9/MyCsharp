using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class FIbonacci
    {
        public static int Of(int n) 
        {
            if (n <= 1) 
            {
                return n;
            }
            return Of(n - 2) + Of(n - 1);
        }
    }
}
