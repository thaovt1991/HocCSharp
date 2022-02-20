using System;
using System.Collections.Generic;

namespace ListCollectionsSort
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
            Employee emp5 = new Employee()
            {
                ID = 105,
                Name = "Hina",
                Gender = "Female",
                Salary = 7500
            };
            Employee emp6 = new Employee()
            {
                ID = 106,
                Name = "Tarun",
                Gender = "Male",
                Salary = 6000
            };
            List<Employee> listEmployees = new List<Employee>();
            listEmployees.Add(emp1);
            listEmployees.Add(emp2);
            listEmployees.Add(emp3);
            listEmployees.Add(emp4);
            listEmployees.Add(emp5);
            listEmployees.Add(emp6);
            Console.WriteLine("Employees before sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            //sort ham mac dinh trong lop viet lai bang competo
            //listEmployees.Sort();

            SortByName sortByName = new SortByName();
            //sort bang comparer 
            listEmployees.Sort(sortByName);


            Console.WriteLine("Employees After sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            Console.WriteLine();
            listEmployees.Sort();


            Console.WriteLine("Employees After sorting");
            foreach (Employee employee in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1},  Gender = {2}, Salary = {3}",
                    employee.ID, employee.Name, employee.Gender, employee.Salary);
            }
            Console.ReadKey();
        }
    }
    public class Employee : IComparable<Employee>
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }

        //public int CompareTo(Employee obj)
        //{
        //    if (this.Salary > obj.Salary)
        //    {
        //        return 1;
        //    }
        //    else if (this.Salary < obj.Salary)
        //    {
        //        return -1;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
        public int CompareTo(Employee obj)
        {
            return this.Gender.CompareTo(obj.Gender);
          
        }

    }

    public class SortByName : IComparer<Employee>
    {
        public int Compare(Employee x, Employee y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
