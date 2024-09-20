using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace KhopXau
{
    internal class Program
    {


        public static int[] KhopXau(string xau, string target)
        {
            List<int> result = new List<int>();
            if (string.IsNullOrEmpty(xau) || string.IsNullOrEmpty(target)) return null;

            int targetLength = target.Length;
            int xauLength = xau.Length;

            for (int i = 0; i <= xauLength - targetLength; i++)
            {
                bool match = true;
                for (int j = 0; j < targetLength; j++)
                {
                    if (xau[i + j] != target[j])
                    {
                        match = false;
                        break;
                    }
                }
                if (match)
                {
                    result.Add(i + 1); 
                    i += targetLength - 1; 
                }
            }

            return result.ToArray();
        }


        public static int[] KhopXauv2(string xau, string target)
        {
            List<int> result = new List<int>();
            if (string.IsNullOrEmpty(xau) || string.IsNullOrEmpty(target)) return null;

            int targetLength = target.Length;
            int xauLength = xau.Length;

            for (int i = 0; i <= xauLength - targetLength; i++)
            {
                if (xau.Substring(i, targetLength) == target)
                {
                    result.Add(i + 1); 
                    i += targetLength - 1; 
                }
            }
            return result.ToArray();
        }
        
        public static void Main(string[] args)
        {
            
            Stopwatch stopwatch = new Stopwatch();

            // Bắt đầu đo thời gian
            stopwatch.Start();
            
            string input = "abababc";
            string target = "ba";
            var result = KhopXau(input, target);

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
            }
            
            stopwatch.Stop();

           
            Console.WriteLine($"RunTime: {stopwatch.ElapsedMilliseconds} ms");
                
        }
    }
}