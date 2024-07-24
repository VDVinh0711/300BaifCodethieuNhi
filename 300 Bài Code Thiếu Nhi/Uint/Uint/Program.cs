using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            uint number =00000000000000000000000000001011;
            int count = 0;
           
                if ((number & 1) == 1)
                {
                    count++;
                }
                // Right shift the number by 1 to check the next bit
                number >>= 1;
          
            Console.WriteLine(number & 1);
        }
    }
}