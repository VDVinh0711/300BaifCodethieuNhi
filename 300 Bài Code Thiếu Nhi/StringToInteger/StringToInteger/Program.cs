using System;

namespace StringToInteger
{
    internal class Program
    {
        public static int MyAtoi(string s)
        {
            if (string.IsNullOrEmpty(s))
                return 0;
        
            int index = 0;
            int sign = 1;
            int result = 0;
        
         
            while (index < s.Length && s[index] == ' ')
                index++;
        
          
            if (index < s.Length && (s[index] == '+' || s[index] == '-')) {
                sign = s[index] == '+' ? 1 : -1;
                index++;
            }
        
         
            while (index < s.Length && char.IsDigit(s[index])) {
                int digit = s[index] - '0';
            
                
                if (result > int.MaxValue / 10 || (result == int.MaxValue / 10 && digit > int.MaxValue % 10)) {
                    return sign == 1 ? int.MaxValue : int.MinValue;
                }
            
                result = result * 10 + digit;
                index++;
            }
        
            return sign * result;
        }
        public static void Main(string[] args)
        {
            Console.Write(MyAtoi("1337c0d3"));
        }
    }
}