using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class CuttingRodProblem
    {
        public static int CutRod(int[] prices, int n) 
        {
            int[] val = new int[n+1];
            val[0] = 0;
            for (int i=1;i<=n;++i)
            {
                int max_val = int.MinValue;
                for (int j=0;j<i;++j)//upto where we want to make the cut
                {
                    max_val = Math.Max(max_val, prices[j] + val[i-j-1]);//here i expresses the maximum limit for a cut and j expresses the index till where the cut will be made
                    val[i] = max_val;
                }
            }
            return val[n];
        }
    }
}
