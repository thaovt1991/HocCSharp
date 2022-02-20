using System;
using System.Collections.Generic;
using System.Linq;

namespace ConverToDictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Create Employee object
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 20000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Priyanka",
                Gender = "Female",
                Salary = 30000
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Anurag",
                Gender = "Male",
                Salary = 40000
            };

            // Create an array of employees with size 3
            // Store the 3 employees into the array
            Employee[] arrayEmployees = new Employee[3];
            arrayEmployees[0] = emp1;
            arrayEmployees[1] = emp2;
            arrayEmployees[2] = emp3;
            // To convert an array to a List, use ToList() method
            List<Employee> listEmployees = arrayEmployees.ToList();
            foreach (Employee emp in listEmployees)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();
            // To convert a List to an array, use ToLArray() method
            Employee[] arrayAllEmployeesFromList = listEmployees.ToArray();
            foreach (Employee emp in arrayAllEmployeesFromList)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();


            // To convert a List to a Dictionary, use ToDictionary() method
            Dictionary<int, Employee> dictionaryEmployees = listEmployees.ToDictionary(x => x.ID);
            foreach (KeyValuePair<int, Employee> keyValuePairEmployees in dictionaryEmployees)
            {
                Console.WriteLine("Key = {0}", keyValuePairEmployees.Key);
                Employee emp = keyValuePairEmployees.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();


            // To convert an array to a Dictionary, use ToDictionary() method
            Dictionary<int, Employee> dictionaryEmployeesFromArray = arrayEmployees.ToDictionary(employee => employee.ID, employee => employee);
            // Loop thru the dictionary and print the key/value pairs
            foreach (KeyValuePair<int, Employee> kvp in dictionaryEmployeesFromArray)
            {
                Console.WriteLine("Key = {0}", kvp.Key);
                Employee emp = kvp.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }


            // To Convert a dictionaty to an array, use ToArray method on the Values 
            // Peoperty of the dictionary object
            Employee[] arrayAllEmployeesFromDictionary = dictionaryEmployeesFromArray.Values.ToArray();
            foreach (Employee emp in arrayAllEmployeesFromDictionary)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }
            Console.WriteLine();
            // To Convert a dictionary to a List, use To List method on the Values
            // Property of the dictionary object
            List<Employee> listAllEmployeesFromDictionary = dictionaryEmployeesFromArray.Values.ToList();
            foreach (Employee emp in listAllEmployeesFromDictionary)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Gender ={2}, Salary = {3}",
                               emp.ID, emp.Name, emp.Gender, emp.Salary);
            }

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
