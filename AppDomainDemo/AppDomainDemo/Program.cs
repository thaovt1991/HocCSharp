using System;
namespace AppDomainDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Third Party DLL
            ThirdParty Obj3 = new ThirdParty();
            //Own DLL
            MyClass1 obj1 = new MyClass1();
            MyClass2 obj2 = new MyClass2();
            Console.Read();
        }
    }
    [Serializable]
    public class ThirdParty
    {
        public ThirdParty()
        {
            Console.WriteLine("Third Party DLL Loaded");
            System.IO.File.Create(@"E:\xyz.txt");
        }
        ~ThirdParty()
        {
            Console.WriteLine("Third Party DLL Unloaded");
        }
    }

    public class MyClass1
    {
    }
    public class MyClass2
    {
    }
}