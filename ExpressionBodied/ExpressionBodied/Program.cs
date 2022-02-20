using System;

namespace ExpressionBodied  // giong arrow fuction
{
    public class Employee
    {
        private string FirstName;
        private string LastName;
        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        public string GetFullName() => $"{FirstName} {LastName}";
        public override string ToString() => $"{FirstName} {LastName}";
        public void DisplayName() => Console.WriteLine(GetFullName());
    }
    class Program
    {
        static void Main()
        {
            Employee employee = new Employee("Pranaya", "Rout");
            employee.DisplayName();
            Console.WriteLine(employee);
            Console.WriteLine("Press any key to exists");
            Console.ReadKey();
        }
    }
}
