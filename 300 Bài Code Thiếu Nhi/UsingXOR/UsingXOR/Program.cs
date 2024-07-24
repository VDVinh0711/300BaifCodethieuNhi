using System;
using System.Collections.Generic;

namespace UsingXOR
{
    internal class Program
    {


        public int[] Intersect(int[] nums1, int[] nums2)
        {
            List<int> results = new List<int>();
            if (nums1.Length == 0 || nums2.Length == 0) return results.ToArray();
            Dictionary<int, int> countNumber = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (countNumber.ContainsKey(nums1[i]))
                {
                    countNumber[nums1[i]]++;
                }
                else
                {
                    countNumber[nums1[i]] = 1;
                }
            }

            for (int j = 0; j < nums2.Length; j++)
            {
                if (countNumber.ContainsKey(nums2[j]) && countNumber[nums2[j]] > 0)
                {
                    results.Add(nums2[j]);
                    countNumber[nums2[j]]--;
                }
            }
            return results.ToArray();
        }

        public static void Main(string[] args)
        {
            int number1 = 1;
            int number2 = 3;
            Console.Write(number1^number2);
        }
    }
}