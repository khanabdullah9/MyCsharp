using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class TwoDimensional
    {
        public static void Run() 
        {
            int[,] twoD = new int[5, 4];
            //Console.WriteLine(twoD.Rank);//dimension
            //Console.WriteLine(twoD.Length);//row x column
            //Console.WriteLine(twoD.GetLength(0));//get length of the specified rank. In this case the first rank
            int rowLength = twoD.GetLength(0);
            int colLength = twoD.GetLength(1);
            Console.WriteLine($"{rowLength}\n{colLength}");
        }
    }
}
