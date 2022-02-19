using System;

namespace AssemblyOne
{
    public class AssemblyOneClassI
    {
        //internal int ID = 999;
        protected internal int ID = 999;

        public int ID2 = 999;
    }
    public class AssemblyOneClassII
    {
        public void Test()
        {
            AssemblyOneClassI instance = new AssemblyOneClassI();
            // Can access inetrnal member ID as both AssemblyOneClassII and AssemblyOneClassI
            // are present in the same assembly            
            Console.WriteLine(instance.ID);
     
        }
    }

    //Class is marked internal. This class is available only within AssemblyOne
    internal class AssemblyOneClass
    {
        public void Print()
        {
            Console.WriteLine("Hello");
        }
    }
}
