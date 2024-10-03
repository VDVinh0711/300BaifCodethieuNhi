using System;
using System.Collections.Generic;

namespace Triangle
{
    internal class Program
    {

        public static int Minimuntotla(List<List<int>> triangle)
        {
            
            int n = triangle.Count;
            List<List<int>> f = new List<List<int>> { new List<int> { triangle[0][0] } };
        
            for (int i = 1; i < triangle.Count; i++) {
                f.Add(new List<int>());
            
                for (int j = 0; j < triangle[i].Count; j++) {
                    if (j == 0)
                        f[i].Add(triangle[i][j] + f[i-1][j]);
                    else if (j == triangle[i].Count - 1)
                        f[i].Add(triangle[i][j] + f[i-1][j-1]);
                    else
                        f[i].Add(Math.Min(f[i-1][j-1], f[i-1][j]) + triangle[i][j]);
                }
            }

            int result = f[n-1][0];
            for (int i = 0; i < triangle[n-1].Count; i++) {
                if (f[n-1][i] < result) {
                    result = f[n-1][i];
                }
            }
        
            return result;
        }
        
        public static void Main(string[] args)
        {
            
            
        }
    }
}