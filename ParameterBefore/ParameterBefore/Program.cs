using System;

namespace ParameterBefore
{
    class Program
    {
        //    static void Main()
        //    {
        //        string EmployeeName, Gender, Department;
        //        long Salary;
        //        GetEmployeeDetails(out EmployeeName, out Gender, out Salary, out Department);
        //        Console.WriteLine("Employee Details:");
        //        Console.WriteLine("Name: {0}, Gender: {1}, Salary: {2}, Department: {3}",
        //        EmployeeName, Gender, Salary, Department);
        //        Console.WriteLine("Press any key to exit.");
        //        Console.ReadKey();
        //    }
        //    static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
        //    {
        //        EmployeeName = "Pranaya Rout";
        //        Gender = "Male";
        //        Salary = 20000;
        //        Department = "IT";
        //    }
        //}
        static void Main(string[] args)
        {

            //string Em, Gender, Depa;
            //long Salary;

            //GetEmployeeDetails(out Em, out Gender, out Salary, out Depa);

            //Console.WriteLine("Employee Details:");
            //Console.WriteLine("Name: {0}, Gender: {1}, Salary: {2}, Department: {3}",
            //Em, Gender, Salary, Depa);
                string s = "09-Juntttttttttt-2018";
                //DateTime date;
                //if (DateTime.TryParse(s, out date))
                if (DateTime.TryParse(s, out DateTime date))
                {
                    Console.WriteLine(date);
                }
                Console.WriteLine(date);
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

        }

        static void GetEmployeeDetails(out string EmployeeName, out string Gender, out long Salary, out string Department)
        {
            EmployeeName = "Pranaya Rout";
            Gender = "Male";
            Salary = 20000;
            Department = "IT";
        }
    }
}