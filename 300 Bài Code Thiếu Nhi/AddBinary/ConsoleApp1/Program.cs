

/*Given two binary strings a and b, return their sum as a binary string.

Example 1:
Input: a = "11", b = "1"
Output: "100"

Example 2:
Input: a = "1010", b = "1011"
Output: "10101"
 */

using System;

namespace MyApp
{
    internal class Program
    {

        static string AddBinary(string a , string b)
        {
            int maxLength = a.Length >= b.Length ? a.Length : b.Length;

            a = a.PadLeft(maxLength, '0');
            b = b.PadLeft(maxLength, '0');
            string result = "";
            int carry = 0;
            for(int i = maxLength-1; i >=0; i--)
            {
                int aNumber = int.Parse(a[i].ToString());
                int bNumber = int.Parse(b[i].ToString());
                int sum = aNumber + bNumber + carry;
                carry = sum / 2;
                result = (sum % 2).ToString() + result;
            }
            if (carry > 0)
                result = "1" + result;
            return result;
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(AddBinary(a, b));
        }
    }
}