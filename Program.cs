using System.Collections;
using LeetCode;

namespace csharp 
{
    public class Program 
    {
        public static void Main()
        {
            string input = "babad";
            string input2 = "zqbabre";
            var op = LongestPalindromicString.LongestPalindrome(input2);
            Console.WriteLine("Lenght is "+op);
        }
    }
}