using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class LongestCommonPrefix
    {
        /*
         Input: strs = ["flower","flow","flight"]
         Output: "fl"
                strs = [ "dog", "racecar", "car"] 
        Output: null
         */
        public static string Find(string[] strs) 
        {
            if (strs.Length == 0) { return string.Empty; }
            string prefix = strs[0];
            for (int i=0;i<strs.Length;++i)
            {
                while (strs[i].IndexOf(prefix) != 0) 
                {
                    prefix = prefix.Substring(0,prefix.Length-1);
                }
            }
            return prefix;
        }
    }
}
