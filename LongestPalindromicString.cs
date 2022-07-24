using System;

namespace LeetCode 
{
    internal class LongestPalindromicString
    {
        public static string GetSubstring(string s, int low, int high)
        {
            return s.Substring(low,high-low+1);
        }
        public static int LongestPalindrome(string s) 
        {
            int n = s.Length;
            bool[,] table = new bool[n,n];
            int maxLength = 1;
            for (int i=0;i<n;++i) //substrings of length 1 // This will fill the diagonal cells
            {
                table[i, i] = true;
            }
            int start = 0;//where to start from while picking the substring
            for (int i=0;i<n-1;++i) //substrings of length 2
            {
                if (s[i] == s[i+1]) 
                {
                    table[i, i + 1] = true;
                    start = i;
                    maxLength = 2;
                }
            }
            for (int k=3;k<=n;++k)//substrings greater than 2//Here k is the length of the substring
            {
                for (int i=0;i<n-k+1;++i) //fix the starting index and check for all the substring of length greater than 3
                {
                    int j = i + k - 1;//j is the lenth of the substring//i is the starting index and k is the length for the current iteration
                    /*
                        NOW CHECKING FOR THE SUBSTRING FROM ith INDEX TO THE jth INDEX IF 
                        s[i+1] and s[j-1] ARE PALINDROMES AS WELL
                     */
                    if (table[i+1,j-1] && s[i] == s[j])
                    {
                        table[i, j] = true;
                        if (k > maxLength)
                        {
                            start = i;
                            maxLength = k;
                        }
                    }
                }
            }
            Console.WriteLine($"Longest palindrom substring is {GetSubstring(s,start,start+maxLength-1)}");
            //PrintTable(table);
            return maxLength;
        }
        public static void PrintTable(bool[,] table)
        {
            Console.WriteLine("Table looks like: ");
            for (int i=0;i<table.GetLength(0);++i)
            {
                for (int j=0;j<table.GetLength(1);++j)
                {
                    Console.Write(Convert.ToInt32(table[i,j])+" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}