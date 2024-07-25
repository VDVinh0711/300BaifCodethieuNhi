using System;
using System.Collections.Generic;

namespace ValidAnagram
{
    internal class Program
    {
        public static bool IsAnagram(string s, string t)
        {
            if (s.Length != t.Length) return false;
            Dictionary<char, int> cacheCount = new Dictionary<char, int>();
            for (int i = 0; i < s.Length; i++)
            {
                if (cacheCount.ContainsKey(s[i]))
                {
                    cacheCount[s[i]]++;
                    continue;
                }

                cacheCount[s[i]] = 1;
            }

            for (int i = 0; i < t.Length; i++)
            {
                if (cacheCount.ContainsKey(t[i]) && cacheCount[t[i]] > 0)
                {
                    cacheCount[t[i]]--;
                }
                else
                {
                    return false;
                }
            }
                
            return true;
        }
        public static void Main(string[] args)
        {
            string s = "rat";
            string t = "car";
            Console.WriteLine(IsAnagram(s,t));
        }
    }
}