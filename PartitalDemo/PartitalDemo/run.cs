using System;

namespace PartitalDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PartialEmployee emp = new PartialEmployee();
            emp.FirstName = "Pranaya";
            emp.LastName = "Rout";
            emp.Salary = 100000;
            emp.Gender = "Male";
            emp.DisplayFullName();

            emp.DisplayEmployeeDetails();

            PartialClass SC = new PartialClass();
            SC.PublicMethod();

            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}
