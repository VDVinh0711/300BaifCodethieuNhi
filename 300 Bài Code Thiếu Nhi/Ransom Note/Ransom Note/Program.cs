using System;

namespace MyApp
{
    internal class Program
    {

        static bool RanSomNote(string ransomNote , string magazine)
        {
            
            int count = 0;
            var ransomnoteList = new List<char>(ransomNote);
            foreach (char c in magazine)
            {
               if(ransomnoteList.Remove(c))
                {
                    count++;
                }
            }
            return count == ransomNote.Length;
        }
        static void Main(string[] args)
        {
           string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(RanSomNote(a,b));
        }
    }
}