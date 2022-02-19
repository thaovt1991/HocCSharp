using System;

namespace InterfaceDemo
{
    public interface Interface1
    {
        void Test();
        void Show();
    }
    public interface Interface2
    {
        void Test();
        void Show();
    }

    public interface A : Interface1,Interface2 { }
    class ImplementInterafce : A
    {
        //public void Test()
        //{
        //    Console.WriteLine("Test method is implemented");
        //}
        //public void Show()
        //{
        //    Console.WriteLine("Show mwthod is implemented");
        //}
        void Interface1.Test()
        {
            Console.WriteLine("Test mthod of interafce1 is implemented");
        }
        void Interface1.Show()
        {
            Console.WriteLine("Show mwthod of interafce1 is implemented");
        }
        void Interface2.Test()
        {
            Console.WriteLine("Test mthod of interface2 is implemented");
        }
        void Interface2.Show()
        {
            Console.WriteLine("Show mwthod of interafce2 is implemented");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ImplementInterafce obj = new ImplementInterafce();
            ((Interface1)obj).Test();
            ((Interface2)obj).Show();
            Interface1 obj1 = new ImplementInterafce();
            obj1.Test();
            obj1.Show();
            Interface2 obj2 = new ImplementInterafce();
            obj2.Test();
            obj2.Show();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}
