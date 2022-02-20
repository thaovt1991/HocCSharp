using System;

using System.Threading.Tasks;

namespace AsyncMain
{
    class Program
    {
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Before C# 7.1, To use async method");
        //    Console.WriteLine($"Main Method execution started at {System.DateTime.Now}");
        //    Task.Delay(2000).GetAwaiter().GetResult();
        //    Console.WriteLine($"Main Method execution ended at {System.DateTime.Now}");
        //    Console.WriteLine("Press any key to exist.");
        //    Console.ReadKey();
        //}

        //static async Task Main(string[] args)
        //{
        //    Console.WriteLine("In C# 7.1, To use async method");
        //    Console.WriteLine($"Main Method execution started at {System.DateTime.Now}");
        //    await Task.Delay(2000);
        //    Console.WriteLine($"Main Method execution ended at {System.DateTime.Now}");
        //    Console.WriteLine("Press any key to exist.");
        //    Console.ReadKey();
        //}
        public static async Task<int> Main(string[] args)
        {
            Console.Title = "async Task<int> Main";
            int number1 = 5, number2 = 10;
            Console.WriteLine($"Sum of {number1} and {number2} is: {await AdditionAsync(number1, number2)}");
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
            return 0;
        }

        //hinh nhu goi Task bang await
        private static Task<int> AdditionAsync(int no1, int no2)
        {
            return Task.Run(() => SUM(no1, no2));
            //Local function 
            int SUM(int x, int y)
            {
                return x + y;
            }
        }
    }
}
