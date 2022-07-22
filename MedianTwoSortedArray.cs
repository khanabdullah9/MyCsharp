using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    internal class MedianTwoSortedArray
    {
        public double Find(int[] nums1, int[] nums2)
        {
            int[] merged = MergeTwoArrays(nums1,nums2);//2n space complexity
            double result = 0;
            Sort(merged,0,merged.Length-1);//array needs to be sorted as per the question
            Console.WriteLine("Sorted merged array is: ");
            PrintArray(merged);
            if (merged.Length % 2 == 0)
            {
                double mid1 = merged[(merged.Length / 2) -1];
                double mid2 = merged[((merged.Length / 2) - 1)+1];
                Console.WriteLine($"Returning the average of {mid1} and {mid2}");
                result = (mid1 + mid2) / 2;
            }
            else 
            {
                result = merged[merged.Length / 2];
            }
            return result;
        }

        public int[] MergeTwoArrays(int[] a1, int[] a2) 
        {
            int[] merged = new int[a1.Length+a2.Length];
            int n = 0;
            while (n < a1.Length)
            {
                merged[n] = a1[n];
                n++;
            }
            int p = 0;
            while (p < a2.Length)
            {
                merged[n] = a2[p];
                p++;
                n++;
            }
            return merged;
        }

        public void Merge(int[] container, int low, int mid, int high) 
        {
            int[] merged = new int[high-low+1];
            int idx1 = low;
            int idx2 = mid + 1;
            int x = 0;
            while (idx1 <= mid && idx2 <= high) 
            {
                if (container[idx1] <= container[idx2])
                {
                    merged[x++] = container[idx1++];
                }
                else 
                {
                    merged[x++] = container[idx2++];
                }
            }
            while (idx1 <= mid)
            {
                merged[x++] = container[idx1++];
            }
            while (idx2 <= high)
            {
                merged[x++] = container[idx2++];
            }

            for (int i=0,j=low;i<merged.Length;i++,j++) 
            {
                container[j] = merged[i];
            }
        }
        public  void Sort(int[] container, int low, int high) 
        {
            if (low < high) 
            {
                int mid = low + (high-low) / 2;
                Sort(container,low,mid);
                Sort(container, mid+1, high);
                Merge(container,low,mid,high);
            }
        }

        public void PrintArray(int[] container) 
        {
            Console.WriteLine("The array looks like");
            for (int i=0;i<container.Length;++i) 
            {
                for (int j=0;j<container.Length;++j)
                {
                    Console.Write(container[j]+" ");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
/*
 4. Median of Two Sorted Arrays
Hard

Given two sorted arrays nums1 and nums2 of size m and n respectively, return the median of the two sorted arrays.

The overall run time complexity should be O(log (m+n)).

 

Example 1:

Input: nums1 = [1,3], nums2 = [2]
Output: 2.00000
Explanation: merged array = [1,2,3] and median is 2.

Example 2:

Input: nums1 = [1,2], nums2 = [3,4]
Output: 2.50000
Explanation: merged array = [1,2,3,4] and median is (2 + 3) / 2 = 2.5.

 

Constraints:

    nums1.length == m
    nums2.length == n
    0 <= m <= 1000
    0 <= n <= 1000
    1 <= m + n <= 2000
    -106 <= nums1[i], nums2[i] <= 106


 */
