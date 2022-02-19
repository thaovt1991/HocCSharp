using System;
//using ObjectClassMethods;

namespace UnderstandingObjectClassMethods
{
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello World!");
    //    }
    //}
    ////enum chi cho so
    //public enum Direction
    //{
    //    Binh = 2,
    //    Phuong = 3,
    //    Buu = 5,
    //}

    public class Program
    {
        public static void Main()
        {
            Customer C1 = new Customer();
            //C1.FirstName = "Pranaya";
            //C1.LastName = "Rout";
            //Customer C2 = new Customer();
            //C2.FirstName = "Pranaya";
            //C2.LastName = "Rout";
            //Console.WriteLine(C1 == C2);
            //Console.WriteLine(C1.Equals(C2));

            //Customer C1 = null;
            //Console.WriteLine("Ten la : "  + Convert.ToString(C1));


            C1.setName("Nam");
            C1.Age = 18;
            Console.WriteLine("Ten la : " + C1.getName() + "Tuoi:  " + C1.Age );

            Console.ReadKey();
        }
    }
    //public class Customer
    //{
    //    public string FirstName { get; set; }
    //    public string LastName { get; set; }
    //    public override bool Equals(object obj)
    //    {
    //        // If the passed object is null
    //        if (obj == null)
    //        {
    //            return false;
    //        }
    //        if (!(obj is Customer))
    //        {
    //            return false;
    //        }
    //        return (this.FirstName == ((Customer)obj).FirstName)
    //            && (this.LastName == ((Customer)obj).LastName);
    //    }
    //    public override int GetHashCode()
    //    {
    //        return FirstName.GetHashCode() ^ LastName.GetHashCode();
    //    }
    //}
}
