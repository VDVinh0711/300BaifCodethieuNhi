using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

class Program
{
    static void Main()
    {
        Stopwatch stopwatch = new Stopwatch();

        // Bắt đầu đo thời gian
        stopwatch.Start();
        int[] sequence = new int[] {1, 4, 3, 2, 1, 2, 3, 4, 1};
        Console.WriteLine(CalculateInsertions(sequence));
        
        stopwatch.Stop();

        // In ra thời gian đã chạy
        Console.WriteLine($"Thời gian chạy: {stopwatch.ElapsedMilliseconds} ms");
    }

    static int CalculateInsertions(int[] seq)
    {
        int left = 0, right = seq.Length - 1, insertions = 0;
        while (left < right)
        {
            if (seq[left] == seq[right]) { left++; right--; }
            else
            {
                if (seq[left] == seq[right - 1])
                {
                    insertions++;
                    right--;
                    
                }
                else if(seq[left+1] == seq[right])
                {
                    insertions++;
                    left++;
                }
                else
                {
                    insertions += 2;
                    left++;
                    right--;
                }
            }
        }
        return insertions;
    }
}