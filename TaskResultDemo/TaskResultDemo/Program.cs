﻿using System;
using System.Linq;
using System.Threading.Tasks;
namespace GeneralizedAsyncReturnTypes
{
    //    public class Example
    //    {
    //        public static void Main()
    //        {
    //            DisplayCurrentInfo().Wait();
    //            Console.WriteLine("Press any key to exist.");
    //            Console.ReadKey();
    //        }
    //        static async Task DisplayCurrentInfo()
    //        {
    //            await WaitAndApologize();
    //            Console.WriteLine($"Today is {DateTime.Now:D}");
    //            Console.WriteLine($"The current time is {DateTime.Now.TimeOfDay:t}");
    //            Console.WriteLine("The current temperature is 76 degrees.");
    //        }
    //        static async Task WaitAndApologize()
    //        {
    //            // Task.Delay is a placeholder for actual work.  
    //            await Task.Delay(2000);
    //            // Task.Delay delays the following line by two seconds.  
    //            Console.WriteLine("\nSorry for the delay. . . .\n");
    //        }
    //public static void Main()
    //{
    //    Console.WriteLine(ShowTodaysInfo().Result);

    //    Console.WriteLine("Press any key to exist.");
    //    Console.ReadKey();
    //}
    //private static async Task<string> ShowTodaysInfo()
    //{
    //    string ret = $"Today is {DateTime.Today:D}\n" +
    //                 "Today's hours of leisure: " +
    //                 $"{await GetLeisureHours()}";
    //    return ret;
    //}
    //static async Task<int> GetLeisureHours()
    //{
    //    // Task.FromResult is a placeholder for actual work that returns a string.  
    //    var today = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());
    //    // The method then can process the result in some way.  
    //    int leisureHours;
    //    if (today.First() == 'S')
    //        leisureHours = 16;
    //    else
    //        leisureHours = 5;
    //    return leisureHours;
    //}
    // }

    //public class Example
    //{
    //    public static void Main()
    //    {
    //        RunCounter().Wait();
    //        Console.WriteLine("Press any key to exist.");
    //        Console.ReadKey();
    //    }
    //    private static async Task RunCounter()
    //    {
    //        var count = new Counter(5);
    //        await count.StartCounting(8);
    //    }
    //}
    //public class Counter
    //{
    //    private int threshold = 0;
    //    private int iterations = 0;
    //    private int ctr = 0;
    //    event EventHandler<EventArgs> ThresholdReached;
    //    public Counter(int threshold)
    //    {
    //        this.threshold = threshold;
    //        ThresholdReached += thresholdReachedEvent;
    //    }
    //    public async Task<int> StartCounting(int limit)
    //    {
    //        iterations = 1;
    //        for (int index = 0; index <= limit; index++)
    //        {
    //            if (ctr == threshold)
    //                thresholdReachedEvent(this, EventArgs.Empty);
    //            ctr++;
    //            await Task.Delay(500);
    //        }
    //        int retval = ctr + (iterations - 1) * threshold;
    //        Console.WriteLine($"On iteration {iterations}, reached {limit}");
    //        return retval;
    //    }
    //    async void thresholdReachedEvent(object sender, EventArgs e)
    //    {
    //        Console.WriteLine($"Reached {ctr}. Resetting...");
    //        await Task.Delay(1000);
    //        ctr = 0;
    //        iterations++;
    //    }
    //}

    public class Example
    {
        public static void Main()
        {
            Console.WriteLine(ShowTodaysInfo().Result);
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
        private static async ValueTask<string> ShowTodaysInfo()
        {
            var infoTask = GetLeisureHours();
            // You can do other work that does not rely on integerTask before awaiting.
            string ret = $"Today is {DateTime.Today:D}\n" +
                         "Today's hours of leisure: " +
                         $"{await infoTask}";
            return ret;
        }
        static async ValueTask<int> GetLeisureHours()
        {
            // Task.FromResult is a placeholder for actual work that returns a string.  
            var today = await Task.FromResult<string>(DateTime.Now.DayOfWeek.ToString());
            // The method then can process the result in some way.  
            int leisureHours;
            if (today.First() == 'S')
                leisureHours = 16;
            else
                leisureHours = 5;
            return leisureHours;
        }
    }
}
