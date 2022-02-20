using System;
using System.Threading;

namespace LockInThreadDemo
{

    class Program
    {

        static int Count = 0;
        static void Main(string[] args)
        {
            Thread t1 = new Thread(DisplayMessage);
            Thread t2 = new Thread(DisplayMessage);
            Thread t3 = new Thread(DisplayMessage);
            t1.Start();
            t2.Start();
            t3.Start();

            //cho cai thread hoan thanh
            //Wait for all three threads to complete their execution
            t1.Join();
            t2.Join();
            t3.Join();

            Console.WriteLine(Count);
            Console.Read();
        }
        private static object _lockObject = new object();
        static void DisplayMessage()
        {
            //lock (_lockObject)
            //{
            //    Console.Write("[Welcome to the ");
            //    Thread.Sleep(1000);
            //    Console.WriteLine("world of dotnet!]");
            //}
            for (int i = 1; i <= 1000000; i++)
            {
                //Only protecting the shared Count variable
                lock (_lockObject)
                {
                    Count++;
                }
            }
        }
    }
}
