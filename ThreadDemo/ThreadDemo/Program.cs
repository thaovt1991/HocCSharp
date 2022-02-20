using System.Threading;
using System;
namespace ThreadingDemo
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Main Thread Started");
    //        //Creating Threads
    //        Thread t1 = new Thread(Method1)
    //        {
    //            Name = "Thread1"
    //        };
    //        Thread t2 = new Thread(Method2)
    //        {
    //            Name = "Thread2"
    //        };
    //        Thread t3 = new Thread(Method3)
    //        {
    //            Name = "Thread3"
    //        };
    //        //Executing the methods
    //        t1.Start();
    //        t2.Start();
    //        t3.Start();
    //        Console.WriteLine("Main Thread Ended");
    //        Console.Read();
    //    }
    //    static void Method1()
    //    {
    //        Console.WriteLine("Method1 Started using " + Thread.CurrentThread.Name);
    //        for (int i = 1; i <= 5; i++)
    //        {
    //            Console.WriteLine("Method1 :" + i);
    //        }
    //        Console.WriteLine("Method1 Ended using " + Thread.CurrentThread.Name);
    //    }
    //    static void Method2()
    //    {
    //        Console.WriteLine("Method2 Started using " + Thread.CurrentThread.Name);
    //        for (int i = 1; i <= 5; i++)
    //        {
    //            Console.WriteLine("Method2 :" + i);
    //            if (i == 3)
    //            {
    //                Console.WriteLine("Performing the Database Operation Started");
    //                //Sleep for 10 seconds
    //                Thread.Sleep(10000);
    //                Console.WriteLine("Performing the Database Operation Completed");
    //            }
    //        }
    //        Console.WriteLine("Method2 Ended using " + Thread.CurrentThread.Name);
    //    }
    //    static void Method3()
    //    {
    //        Console.WriteLine("Method3 Started using " + Thread.CurrentThread.Name);
    //        for (int i = 1; i <= 5; i++)
    //        {
    //            Console.WriteLine("Method3 :" + i);
    //        }
    //        Console.WriteLine("Method3 Ended using " + Thread.CurrentThread.Name);
    //    }
    //}

    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Creating the ThreadStart Delegate instance by passing the
    //        //method name as a parameter to its constructor
    //        ThreadStart obj = new ThreadStart(DisplayNumbers);
    //        //Passing the ThreadStart Delegate instance as a parameter
    //        //its constructor
    //        Thread t1 = new Thread(obj);
    //        t1.Start();
    //        Console.Read();
    //    }
    //    static void DisplayNumbers()
    //    {
    //        for (int i = 1; i <= 5; i++)
    //        {
    //            Console.WriteLine("Method1 :" + i);
    //        }
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            ParameterizedThreadStart PTSD = new ParameterizedThreadStart(obj.DisplayNumbers);
            Thread t1 = new Thread(PTSD);

            t1.Start(10);
            Console.Read();
        }
        public void DisplayNumbers(object Max)
        {
            int Number = Convert.ToInt32(Max);
            for (int i = 1; i <= Number; i++)
            {
                Console.WriteLine("Method1 :" + i);
            }
        }
    }
}
