using System;

namespace MyApp
{
    internal class Program
    {

        static void PrintStepClaim(int n,int k)
        {
            var list = new int[n + 2];
            list[1] = 1;
            list[0] = 1;
            for(int i=2;i<=n;i++)
            {
                for(int j=1;j <= Math.Min(k,i);j++)
                {
                    list[i] += list[i-j];
                }
            }
            Console.WriteLine(list[n]);
            
        }
        static void Main(string[] args)
        {
            PrintStepClaim(3, 3);

        }
    }
}
