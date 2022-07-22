using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp
{
    internal class MergeSort
    {
        public void Merge(int[] container, int low, int mid, int high) 
        {
            int[] merged = new int[high-low+1];
            int idx1 = low;
            int idx2 = mid+1;
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
            for (int i = low, j = 0; i < merged.Length;++i,++j)
            {
                container[i] = merged[j];
            }
        }
        public void Sort(int[] container, int low, int high) 
        {
            if (low < high) 
            {
                int mid = low + (high - low) / 2;
                Sort(container, low, mid);
                Sort(container, mid+1, high);
                Merge(container, low, mid, high);
            }
        }
    }
}
