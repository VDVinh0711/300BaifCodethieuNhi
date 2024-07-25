using System;
namespace ValidPalindrome
{
    internal class Program
    {
        public static bool IsPalindrome(string s)
        {
            if (s == string.Empty) return true;
            s = s.ToLower();
            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                    continue;
                }
                if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                    continue;
                }
                if (s[left] != s[right]) return false;
                left++;
                right--;
            }
            return true;
        }
        public static void Main(string[] args)
        {
           
            string s2 = "race a car";
          
            
        
            Console.WriteLine(IsPalindrome(s2)); 
           
            
        }
    }
}