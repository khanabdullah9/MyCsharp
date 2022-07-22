using System;

namespace LeetCode 
{
    public class LongestPalindromicString
    {
        public void Find(string s)
        {
            int[,] table = new int[s.Length, s.Length];
            string str = string.Empty;
            int r = 0;
            int c = 0;
            while (r < s.Length && c < s.Length)
            {
                for (int i=r;i<=c;++i)
                {
                    str += s[i];//Selecting the substring
                    if (IsPalindrome(str))//if the substring is  a palindrome set the table cell with value 1
                    {
                        table[r, c] = 1;
                        str = String.Empty;
                    }
                    else //if the substring is not a palindrome set the table cell with value 0
                    {
                        table[r, c] = 0;
                        str = String.Empty;
                    }
                }
                r++; c++;//move to the next indexes
            }
            //PrintTable(table);
            Console.WriteLine($"LongestCommonSubstring from {s} is {LongestPalindromeFromTable(table,s)}");
        }
        public bool IsPalindrome(string s) 
        {
            string str = string.Empty;
            for (int i=s.Length-1;i>=0;--i)
            {
                str += s[i];
            }
            return str.Equals(s);
        }

        /*
         * Find the longest palindrome from the string
         * params: container: table
         * s: input string
         */
        public string LongestPalindromeFromTable(int[,] container, string s) 
        {
            string longest = s.Substring(0,0);
            int r = 0;
            int c = 0;
            string str = string.Empty;
            while (r < s.Length && c < s.Length) 
            {
                if (container[r, c] == 1)
                {
                    for (int i = r; i <= c; ++r)
                    {
                        str += s[i];
                        if (str.Length > longest.Length)
                        {
                            longest = str;
                            str = string.Empty;
                        }
                    }
                    r++; c++;
                }
                else { r++;c++; }
            }
            return longest;
        }
        public void PrintTable(int[,] container) 
        {
            Console.WriteLine("Table looks like: ");
            for (int r=0;r<container.GetLength(0);++r)
            {
                for (int c=0;c<container.GetLength(1);++c) 
                {
                    Console.Write(container[r,c]+" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}