﻿using System;
using System.Threading;

namespace MutexDemo
{
    class Program
    {
        //    private static Mutex mutex = new Mutex();
        //    static void Main(string[] args)
        //    {
        //        //Create multiple threads to understand Mutex
        //        for (int i = 1; i <= 5; i++)
        //        {
        //            Thread threadObject = new Thread(MutexDemo);
        //            threadObject.Name = "Thread " + i;
        //            threadObject.Start();
        //        }
        //        Console.ReadKey();
        //    }
        //    //Method to implement syncronization using Mutex  
        //    static void MutexDemo()
        //    {
        //        Console.WriteLine(Thread.CurrentThread.Name + " Wants to Enter Critical Section for processing");
        //        try
        //        {
        //            //Blocks the current thread until the current WaitOne method receives a signal.  
        //            //Wait until it is safe to enter. 
        //            mutex.WaitOne();
        //            Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Processing now");
        //            Thread.Sleep(2000);
        //            Console.WriteLine("Exit: " + Thread.CurrentThread.Name + " is Completed its task");
        //        }
        //        finally
        //        {
        //            //Call the ReleaseMutex method to unblock so that other threads
        //            //that are trying to gain ownership of the mutex.  
        //            mutex.ReleaseMutex();
        //        }
        //    }
        //}

        public static Semaphore semaphore = new Semaphore(2, 3);

            static void Main(string[] args)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Thread threadObject = new Thread(DoSomeTask)
                    {
                        Name = "Thread " + i
                    };
                    threadObject.Start(i);
                }
                Console.ReadKey();
            }
            static void DoSomeTask(object id)
            {
                Console.WriteLine(Thread.CurrentThread.Name + " Wants to Enter into Critical Section for processing");
                try
                {
                    //Blocks the current thread until the current WaitHandle receives a signal.   
                    semaphore.WaitOne();
                    Console.WriteLine("Success: " + Thread.CurrentThread.Name + " is Doing its work");
                    Thread.Sleep(5000);
                    Console.WriteLine(Thread.CurrentThread.Name + "Exit.");
                }
                finally
                {
                    //Release() method to releage semaphore  
                    semaphore.Release();
                }
            }
        }
    }
