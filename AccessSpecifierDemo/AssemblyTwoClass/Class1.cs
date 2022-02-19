using AssemblyOne;
using System;

namespace AssemblyTwo
{
    public class AssemblyTwoClassI : AssemblyOneClassI
    {
        public void Test()
        {
            AssemblyOneClassI instance = new AssemblyOneClassI();
            // Console.WriteLine(instance.ID); //ko goi dc

            // Access the base class member using the base keyword    
            Console.WriteLine(base.ID);
        }
    }

    //Class is marked public. This class is available in any assembly
    //public class AssemblyTwoClass
    //{
    //    public void Print()
    //    {
    //        AssemblyOneClass instance = new AssemblyOneClass();
    //        instance.Print();
    //    }
    //}
}
