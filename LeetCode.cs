using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class RomanNumerals
    {
        public static int IntToRoman(string s)
        {
            Hashtable table = new Hashtable();
            table.Add("I", 1);
            table.Add("V", 5);
            table.Add("X", 10);
            table.Add("L", 50);
            table.Add("C", 100);
            table.Add("D", 500);
            table.Add("M", 1000);
            int n = s.Length;
            int num = (int)table[s[n - 1].ToString()];
            for (int i=n-2;i>=0;i--) //we are going from right to left
            {
                if ((int)table[s[i].ToString()] >= (int)table[s[i + 1].ToString()]) //if the letter from the right is greater than the letter at the left than add their corresponding numbers
                {
                    num += (int)table[s[i].ToString()];
                }
                else //if the letter from the right is less than the letter at the left than subtract their corresponding numbers
                {
                    num -= (int)table[s[i].ToString()];
                }
            }
            return num;
        }
    }
}
/*
 * 
    I can be placed before V (5) and X (10) to make 4 and 9. 
    X can be placed before L (50) and C (100) to make 40 and 90. 
    C can be placed before D (500) and M (1000) to make 400 and 900.

 */
