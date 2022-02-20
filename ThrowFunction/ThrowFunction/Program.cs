using System;

namespace ThrowFunction
{
    class Employee
    {
        public string FullName { get; }
        public Employee(string name) => FullName = name ?? throw new ArgumentNullException(name);

    //?? d bo qua cai dau tien 
        public string GetFirstName()
        {
            var parts = FullName.Split(' ');
            return (parts.Length > 1) ? parts[0] : throw new InvalidOperationException("Method:GetFirstName, Full Name is not available");
        }
        public string GetLastName() => throw new NotImplementedException("Method GetLastName is not Implemented");
    }
    class Program
    {
        static void Main(string[] args)
        {
            TryWithNameNull();
            TryGetFirstName();
            TryGetLastName();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
        static void TryWithNameNull()
        {
            try
            {
                new Employee(null);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType() + ": " + ex.Message);
            }
        }
        static void TryGetFirstName()
        {
            try
            {
                new Employee("Pranaya").GetFirstName();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType() + ": " + ex.Message);
            }
        }
        static void TryGetLastName()
        {
            try
            {
                new Employee("Pranaya").GetLastName();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType() + ": " + ex.Message);
            }
        }
    }
}
