using System;
using System.Threading;
namespace ThreadDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            Thread thread1 = new Thread(RunThread1);
            thread1.Start();
            Console.WriteLine("Run in Another Thread");
            thread1.Join();
          
            Console.WriteLine("Process success");
        }

        public static void RunThread1()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}