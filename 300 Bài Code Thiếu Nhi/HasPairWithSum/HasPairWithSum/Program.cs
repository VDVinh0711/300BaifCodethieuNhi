using System;
using System.Collections.Generic;

namespace HasPairWithSum
{
    
    //Request : Find in an array to see which 2 numbers are in the array, so that their sum is equal to the given number
    //Test Case [1,2,3,9] , sum = 8 => return false;
    //          [1,2,4,5] , sum = 8 => return true;
    
    internal class Program
    {


        public static bool IsTowpainWithSum(int[] arr, int sum)
        {
            if (arr.Length < 1) return false;
            int left = 0;
            int right = arr.Length - 1;
            while (left < right)
            {
                int sumPair = arr[left] + arr[right];
                if (sumPair < sum)
                {
                    left++;
                }
                else  if (sumPair > sum)
                {
                    right--;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }

        public static bool IsTowpainWithSum2(int[] arr, int sum)
        {
            if (arr.Length < 1) return false;
            List<int> caches = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                int numFind = sum - arr[i];
                if (caches.Contains(numFind))
                {
                    return true;
                }
                caches.Add(arr[i]);
            }
            return false;
        }
        
        
        public static void Main(string[] args)
        {

            int[] a = new int[] { 1, 2, 4, 6 };
            int sum = 8;
            Console.WriteLine(IsTowpainWithSum(a,sum));
            Console.WriteLine(IsTowpainWithSum2(a,sum));
        }
    }
}