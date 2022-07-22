using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class TwoSum
    {
        public static int[] Solution(int[] nums, int target) 
        {
            int[] result = new int[2];
            for (int i=0;i<nums.Length;++i) 
            {
                int currentIdx = i;
                for (int j=i+1;j<nums.Length;++j) 
                {
                    if (nums[currentIdx] + nums[j] == target) 
                    {
                        result[0] = currentIdx ;
                        result[1] = j ;
                    }
                }
            }
            return result;
        }
    }
}
