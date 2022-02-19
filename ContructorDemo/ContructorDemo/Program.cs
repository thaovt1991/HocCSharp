using System;

namespace ConstructorDemo
{
    class Example
    {
        int i;
        static int j;
        public Example()
        {
            i = 100; // cac bien cua tdoi tuong

        }
        static Example()
        {
            j = 100; // cac bien cua lop
        }
        public void Display()
        {
            Console.WriteLine("value of i : " + i);
            i++;
            Console.WriteLine("value of j : " + j);
            j++;
        }
    }
    class Test
    {
        static void Main(string[] args)
        {
            Example e1 = new Example();
            e1.Display();
            e1.Display();
            Example e2 = new Example();
            e2.Display();
            e2.Display();
            Console.ReadKey();
        }
    }
}
