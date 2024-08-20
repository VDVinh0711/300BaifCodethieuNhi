using System;

namespace StrStr
{
    internal class Program
    {
        
        
        public static int StrStr(string haystack, string needle)
        {
            if (haystack == string.Empty || needle == string.Empty) return -1;
            int result = -1;
            if (haystack.Length < needle.Length) return -1;
            
            for (int i = 0; i <= haystack.Length - needle.Length; i++)
            {
                if (haystack[i] == needle[0])
                {
                    int startindex = i;
                    int indexIndeel = 0;
                    while (indexIndeel < needle.Length)
                    {
                        if (haystack[startindex] == needle[indexIndeel])
                        {
                            startindex++;
                            indexIndeel++;
                            result = i;
                        }
                        else
                        { 
                            result = -1;
                           break;
                        }
                    }

                   
                }
            }
            return result;
        }
        public static void Main(string[] args)
        {
            Console.Write(StrStr("sadbutsad","sad"));
        }
    }
}