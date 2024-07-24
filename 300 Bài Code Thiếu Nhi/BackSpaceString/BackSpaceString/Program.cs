using System;
using System.Text;

namespace MyApp
{
    internal class Program
    {

        public static bool BackspaceCompare(string s, string t)
        {
            if (helper(s) == helper(t)) return true;
            return false;
        }
        static string  helper(string s)
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in s)
            {
                if (c == '#')
                {
                  
                    if (sb.Length > 0)
                    {
                        sb.Length--;
                     
                    }
                }
                else
                {
                    sb.Append(c);
                }
                Console.WriteLine(sb.ToString());
            }
  
            return sb.ToString();
        }
    
    static void Main(string[] args)
        {
            Console.WriteLine(helper("ad#c"));
           
        }
    }
}