using System;
using System.Collections;

namespace ArrayListDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrList = new ArrayList();
            arrList.Add(15);
            arrList.Add(15);
            arrList.Add(15);
            arrList.Add(15);
            bool check = arrList.Contains(15);

        
            Console.WriteLine(arrList.LastIndexOf(15));
            if (check)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
            Console.ReadKey();
        }
    }
}
