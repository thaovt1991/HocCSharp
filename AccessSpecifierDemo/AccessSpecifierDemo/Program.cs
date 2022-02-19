using AssemblyOne;
using System;

namespace AccessSpecifierDemo
{
    public class Customer
    {
        protected int ID = 101;
        public void PrintID()
        {
            //Protected member ID is accessible with in Customer class
            Console.WriteLine(this.ID);
        }
    }
    public class CorporateCustomer : Customer
    {
        public void PrintCustomerID()
        {
            CorporateCustomer corporateCustomerInstance = new CorporateCustomer();

            // Can access the base class protected instance member using the derived class object
            Console.WriteLine(corporateCustomerInstance.ID);
            // Can access the base class protected instance member using this or base keyword
            Console.WriteLine(this.ID);
            Console.WriteLine(base.ID);
        }
    }
    public class RetailCustomer
    {
        public void PrintCustomerID()
        {
            RetailCustomer retailCustomerInstance = new RetailCustomer();
            //RetailCustomer class is not deriving from Customer class, hence it is an error
            //to access Customer class protected ID member, using the retailCustomerInstance
            //Console.WriteLine(retailCustomerInstance.ID); //Error
            //Both these below lines also produce the same Error
            //Console.WriteLine(this.ID); // Error
            //Console.WriteLine(base.ID); // Error
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            CorporateCustomer cp = new CorporateCustomer();
            cp.PrintID();
            cp.PrintCustomerID();
            AssemblyOneClassII a2 = new AssemblyOneClassII();
            AssemblyOneClassI a1 = new AssemblyOneClassI();
            
       
            Console.ReadKey();
        }
    }


    //Error: Cannot mark types with private, protected and protected internal access modifiers
    //private class MainClass
    //{
    //    public static void Main()
    //    {
    //        Console.WriteLine("This code will not compile");
    //    }
    //}
}

