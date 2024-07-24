using System;

namespace ConsoleApplication1
{
    
    
    internal class Program
    {
        static void display(int[] a, int n)
        {
            Console.Write("[");
            for(int i=0;i<n;i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.Write("]");
            Console.WriteLine();
        }
        public static void Main(string[] args)
        {
            int end = int.Parse(Console.ReadLine());
            int[] a = new int[10];
            for (int i = 0; i < end; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            while (end > 0)
            {
                display(a,end);
                for (int i = 0; i < end - 1; i++)
                {
                    a[i] = a[i] + a[i + 1];
                }
                end--;
            }

        }
    }
}