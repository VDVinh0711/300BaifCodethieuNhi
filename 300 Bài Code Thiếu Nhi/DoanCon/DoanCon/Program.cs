using System;

namespace DoanCon
{
    internal class Program
    {   
        public static int CountSubArrayEqualZero(int[] nums)
        {
            int result = 0;
            for (int i = 0; i < nums.Length-1; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length ; j++)
                {
                    sum += nums[j];
                    if (sum == 0)
                    {
                        result++;
                        break;
                    }
                }
            }
            return result;
        }
        public static void Main(string[] args)
        {
            int[] input = new int[] { -3,1,0,-1,3};
            Console.WriteLine(CountSubArrayEqualZero(input));
        }
    }
}