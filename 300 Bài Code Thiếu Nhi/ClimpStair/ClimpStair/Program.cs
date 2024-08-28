using System;

namespace ClimpStair
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int n = 6;
            int[] F = new int[n + 2];
            F[1] = 1;
            F[2] = 2;
            for (int i = 3; i <= n; i++)
            {
                F[i] = F[i - 1] + F[i - 2];
            }
            Console.Write(F[n]);

        }
    }
}