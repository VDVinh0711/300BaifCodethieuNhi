using System;

namespace MyApp
{
    internal class Program
    {

        public static  int RomanToInt(string s)
        {
            int sum = convertToInt(s[s.Length - 1]);
            Console.WriteLine(s.Length);
            for (int i = s.Length - 2; i >= 0; i--)
            {
                if (convertToInt(s[i]) < convertToInt(s[i + 1]))
                {
                    sum -= convertToInt(s[i]);
                }
                else
                {
                    sum += convertToInt(s[i]);
                }
                Console.WriteLine(sum);
            }
            return sum;
        }


       static int  convertToInt(char c)
        {
            switch (c)
            {
                case 'I':
                    return 1;
                    break;
                case 'V':
                    return 5;
                    break;
                case 'X':
                    return 10;
                    break;
                case 'L':
                    return 50;
                    break;
                case 'C':
                    return 100;
                    break;

                case 'D':
                    return 500;
                    break;
                case 'M':
                    return 1000;
                    break;

            }
            return 0;
        }
        static void Main(string[] args)
        {

           Console.WriteLine(RomanToInt("III")) ;
        }
    }
}