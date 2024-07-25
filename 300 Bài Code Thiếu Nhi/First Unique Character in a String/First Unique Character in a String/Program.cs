using System;
using System.Collections.Generic;

namespace First_Unique_Character_in_a_String
{
    internal class Program
    {
        public static int FirstUniqChar(string s) {
            Dictionary<char, int> charCount = new Dictionary<char, int>();
            for(int i=0;i<s.Length;i++)
            {
                if(charCount.ContainsKey(s[i]))
                {
                    charCount[s[i]]++;
                    continue;
                }
                charCount[s[i]] = 1;
            }
            for(int i =0 ;i< s.Length;i++)
            {
                if(charCount[s[i]] == 1) 
                {
                    return i;
                }
            }
            return -1;
        
        }
        public static void Main(string[] args)
        {
            Console.WriteLine(FirstUniqChar("leetcode"));
            Console.WriteLine(FirstUniqChar("loveleetcode"));
        }
    }
}