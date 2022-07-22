using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LongestCommonSequence
    {
        public static int Length(string s)
        {
            string op = string.Empty;
            for (int i=0;i<s.Length;++i) 
            {
                if (!op.Contains(s[i]))
                {
                    op += s[i].ToString();
                    for (int j = i + 1; j < s.Length; ++j)
                    {
                        if (!op.Contains(s[j]))
                        {
                            op += s[j].ToString();//concatinating
                        }
                    }
                }
            }
            Console.WriteLine(op);
            return op.Length;
        }
        //NOTE: Use the string.Substring() method to find the substring
    }
}
