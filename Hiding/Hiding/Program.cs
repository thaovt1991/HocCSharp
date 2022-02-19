using System;

namespace Hiding
{
    class Class1
    {
        public void display()
        {
            Console.WriteLine("Super class display method");
        }
    }
    class Class2 : Class1
    {
        //them chu "new" de an ham va override ham moi
        public new void display()
        {
            Console.WriteLine("class2222222222222 display method");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.display();


            Console.WriteLine("Super methol");
            Class1 obj2 = new Class2();
            obj2.display();
            Console.ReadKey();
        }
    }
}

