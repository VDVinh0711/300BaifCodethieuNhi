using System;

namespace CountPrimes
{
    internal class Program
    {
        
        public static bool IsPrimes(int n)
        {
            if(n <2) return false;
            int count = 0;
            for(int i=1;i<= Math.Sqrt(n);i++)
            {
                if(n%i ==0)
                {
                    count++;
                }
                
            }
            return count <2 ? true : false;
        }
        public static void Main(string[] args)
        {
            
            Console.Write(IsPrimes(4));
        }
    }
}