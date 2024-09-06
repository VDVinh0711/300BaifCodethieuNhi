using System;

namespace Roman_to_Integer
{
    internal class Program
    {
        
        
        
        public static int RomanToInt(string s) {
        
            int result = 0;
            for(int i=0 ;i< s.Length-1;i++)
            {
                if(ConvertToInt(s[i]) < ConvertToInt(s[i+1]) )
                {
                    result -= ConvertToInt(s[i]);
                }
                else
                {
                    result +=ConvertToInt(s[i]);
                }
            }
            return result +=   ConvertToInt(s[s.Length-1]);      

        }
    
       public  static int ConvertToInt(char c)
        {
            switch(c)
            {
                case 'I' :
                    return 1;
                    break;
                case 'V' :
                    return 5;
                    break;
                case 'X' :
                    return 10;
                    break;
                case 'L' :
                    return 50;
                    break;
                case 'C' :
                    return 100;
                    break;
                case 'D' :
                    return 500;
                    break;
                case 'M' :
                    return 1000;
                    break;
            }

            return 0;
        }
        public static void Main(string[] args)
        {
            string input = "LVIII";
            Console.Write(RomanToInt(input));
        }
    }
}