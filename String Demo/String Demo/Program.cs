using System;
using System.Diagnostics;
namespace StringDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "";
            Console.WriteLine("Loop Started");
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 30000000; i++)
            {
                str = Guid.NewGuid().ToString();
            }
            stopwatch.Stop();
            Console.WriteLine("Loop Ended");
            Console.WriteLine("Loop Exceution Time in MS :" + stopwatch.ElapsedMilliseconds);
            Console.ReadKey();
        }
    }
}