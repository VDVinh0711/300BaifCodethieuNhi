using System;

namespace PowerOfThreee
{
    internal class Program
    {
        
        public static bool IsPowerOfThree(int n) {
            if (n <= 0) return false;
            double logResult = Math.Log10(n) / Math.Log10(3);
            return Math.Abs(logResult - Math.Round(logResult)) < 1e-10;

            
            
            
        }
        
       
        public static void Main(string[] args)
        {
        
            
            
        }
    }
}