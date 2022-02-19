
using ClassLibrary;
using System;
using ClassLibrary2;



namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Using MyClassLibrary DLL
            Class1 obj = new Class1();
            Class2 obj2 = new Class2();
            Console.WriteLine(obj.GetData());
            Console.WriteLine(obj2.ShowHang());


            Console.WriteLine("This is From Console App");
            Console.ReadKey();
        }
    }

 
}
