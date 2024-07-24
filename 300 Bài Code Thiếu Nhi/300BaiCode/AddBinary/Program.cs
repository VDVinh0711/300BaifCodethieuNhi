
/*Given two binary strings a and b, return their sum as a binary string.
Example 1:
Input: a = "11", b = "1"
Output: "100"
Example 2:
Input: a = "1010", b = "1011"
Output: "10101"*/

using System;

namespace AddBinary
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string binary1 = "11";
            string binary2 = "1";
            string result = AddBinaryNumbers(binary1, binary2);
            Console.WriteLine("Kết quả cộng hai số nhị phân là: {0}", result);
        }
        public static string AddBinaryNumbers(string binary1, string binary2)
        {
            // Chuyển đổi chuỗi nhị phân sang kiểu dữ liệu int
            int num1 = Convert.ToInt32(binary1, 2);
            int num2 = Convert.ToInt32(binary2, 2);

            // Cộng hai số thập phân
            int sum = num1 + num2;

            // Chuyển đổi số thập phân sang chuỗi nhị phân
            string binarySum = Convert.ToString(sum, 2);

            return binarySum;
        }
    }
}