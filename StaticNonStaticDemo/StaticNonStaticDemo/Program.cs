using System;

namespace StaticNonStaticDemo
{
    //class Example
    //{
    //    int x; // Non statuc variable
    //    static int y = 200; //Static Variable
    //    public Example(int x)
    //    {
    //        this.x = x;
    //    }
    //    static void Main(string[] args)
    //    {
    //        //Accessing the static variable using class name
    //        //Before object creation
    //        Console.WriteLine("Static Variable Y = " + Example.y);

    //        //Creating object1
    //        Example obj1 = new Example(50);

    //        //Creating object2
    //        Example obj2 = new Example(100);

    //        Console.WriteLine($"object1 x = {obj1.x}  object2 x = {obj2.x}");

    //        Console.WriteLine("Press any key to exit.");
    //        Console.ReadLine();
    //    }
    //}
    //class ConstExample
    //{
    //    //we need to assign a value to the const variable
    //    //at the time of const variable declaration else it will
    //    //give compile time error
    //    public const int number = 5;
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //Const variables are static in nature
    //        //so we can access them by using class name 
    //        Console.WriteLine(ConstExample.number);
    //        //We can also declare constant variable within a function
    //        const int no = 10;
    //        Console.WriteLine(no);
    //        //Once after declaration we cannot change the value 
    //        //of a constant variable. so the below live gives error
    //        //no = 20;
    //        Console.WriteLine("Press any key to exist.");
    //        Console.ReadLine();
    //    }
    //}

    //class ReadOnlyExample
    //{
    //    public readonly int number = 5;
    //    public const int number2 = 5;
    //}
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //         ReadOnlyExample readOnlyInstance = new ReadOnlyExample();
    //         Console.WriteLine(readOnlyInstance.number); //readonly  hamn hang cua doi tuong

    //        //  Console.WriteLine(ReadOnlyExample.number); //const la bien hang cua lowp
    //        Console.WriteLine(ReadOnlyExample.number2);

    //        Console.WriteLine("Press any key to exist.");
    //        Console.ReadLine();
    //    }
    //}


    //class Example
    //{
    //    int x; //Non-static variable
    //    static int y = 200; //Static Variable
    //    const float PI = 3.14f; //Const Variable
    //    readonly bool flag; //Readonly Variable
    //    public Example(int x, bool flag)
    //    {
    //        this.x = x;
    //        this.flag = flag;
    //    }
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine(Example.y);
    //        Console.WriteLine(Example.PI);
    //        Example obj1 = new Example(50, true);
    //        Example obj2 = new Example(100, false);
    //        Console.WriteLine(obj1.x + " " + obj1.x);
    //        Console.WriteLine(obj2.flag + " " + obj2.flag);
    //        Console.WriteLine("Press any key to exist.");
    //        Console.ReadLine();
    //    }
    //}


    class Studient
    {

        private string _name, _address;
        private int _age;

        public int age
        {
            set
            {
                _age = value;
            }
            get
            {
                return _age;
            }
        }
        public string name
        {
            set
            {
                _name = value;

            }
            get
            {
                return _name;
            }
        }
        public string address
        {
            set
            {
                _address = value;
            }
            get
            {
                return _address;
            }
        }
    }

    class Program {
        static void Main(string[] args)
        {
            Studient st = new Studient();
            st.name = "Vo Thao";
            st.age = 18;
            st.address = "Phu Da, Phu Vang, TT Hue";
            Console.WriteLine(st.name);
            Console.WriteLine(st.age);
            Console.WriteLine(st.address);

            Console.ReadKey();
        }
        }
}
