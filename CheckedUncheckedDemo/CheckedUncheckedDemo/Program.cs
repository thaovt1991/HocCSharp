using System;

namespace CheckedUncheckedDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            const int a = 2147483647;
            const int b = 2147483647;

            int c = unchecked( a + b);

            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}
