using System;
using System.Collections.Generic;

namespace Longest_Increasing_Subsequence
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = 10;
            int[] a = new int[] { -2304,5, 2, 3, 4, 9, 10, 5, 6, 7, 8 ,3445};
            List<int> L = new List<int>(n+1);
            List<int> T = new List<int>(n+1);
            L[n + 1] = 1;
            for (int i = n; i >= 0; i--)
            {
                int jmax = n + 1;
                for (int j = i + 1; j < n + 1; j++)
                {
                    if (a[j] > a[i] && L[i] < L[j]) jmax = j;
                    L[i] = L[jmax];
                    T[i] = jmax;
                }
            }


            foreach (var number in L)
            {
                Console.WriteLine(number);
            }
        }
    }
}