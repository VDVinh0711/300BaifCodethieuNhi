using System;
using System.Collections.Generic;

namespace MergSortedArray
{
    internal class Program
    {
        
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {


            if (nums1.Length < m + n) return;
            if (nums2.Length < 1) return;
            List<int> result = new List<int>();
            int i = 0;
            int j = 0;
            while (i < m && j < n) {
                if (nums1[i] <= nums2[j]) {
                    result.Add(nums1[i]);
                    i++;
                } else {
                    result.Add(nums2[j]);
                    j++;
                }
            }
            while (i < m) {
                result.Add(nums1[i]);
                i++;
            }
            while (j < n) {
                result.Add(nums2[j]);
                j++;
            }
            for (int t = 0; t < result.Count; t++) {
                nums1[t] = result[t];
            }
        }
        public static void Main(string[] args)
        {
            int[] n1 = new int[] { 1,2,3,0};
            int[] n2 = new int[] {2};

             Merge(n1, 3, n2, 1);
            foreach (var number in n1)
            {
                Console.WriteLine(number);
            }
        }
    }
}