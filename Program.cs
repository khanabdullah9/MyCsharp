using System.Collections;
using LeetCode;

namespace csharp 
{
    public class Program 
    {
        public static void Main()
        {
            int[] arr = new int[] { 1, 5, 8, 9, 10, 17, 17, 20 };
            int size = arr.Length;
            Console.WriteLine($"Maximum obtainable value is {CuttingRodProblem.CutRod(arr,size)}");
        }
    }
}