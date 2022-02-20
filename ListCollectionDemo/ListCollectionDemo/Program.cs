using System;
using System.Collections.Generic;

namespace ListCollectionDemo
{
    public class Program
    {
        public static void Main()
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 5000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 7000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 4500
            };
            Employee emp4 = new Employee()
            {
                ID = 104,
                Name = "Sambit",
                Gender = "Male",
                Salary = 6500
            };

            List<Employee> listEmployees = new List<Employee>(100);
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            listEmployees.Add(emp4);

            //TrueForAll
            Console.WriteLine("Are all salaries greater than 5000: "
                            + listEmployees.TrueForAll(x => x.Salary > 5000));
            // ReadOnlyCollection will not have Add() or Remove() methods
            System.Collections.ObjectModel.ReadOnlyCollection<Employee>
                            readOnlyEmployees = listEmployees.AsReadOnly();
            Console.WriteLine("Total Items in ReadOnlyCollection = " +
                            readOnlyEmployees.Count);
            // listEmployees list is created with an initial capacity of 50
            // but only 4 items are in the list. The filled percentage is 
            // less than 90 percent threshold.
            Console.WriteLine("List capacity before invoking TrimExcess = " +
                            listEmployees.Capacity);
            // Invoke TrimExcess() to set the capacity to the actual 
            // number of elements in the List
            listEmployees.TrimExcess();
            Console.WriteLine("List capacity After invoking TrimExcess = " +
                            listEmployees.Capacity);

            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }
}
