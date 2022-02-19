using System;
using System.Text;

namespace LocalFunctionDemo
{
    class Program
    {
        static void Main()
        {
            Employee employe1 = new Employee()
            {
                Id = 1001,
                Name = "Pranaya",
                Gender = "Male",
                Salary = 1000,
                Department = "IT"
            };
            bool IsInserted = AddEmployee(employe1);
            Console.WriteLine($"Is Employee with id 1001 inserted: {IsInserted}");
            Employee employee2 = new Employee()
            {
                Id = 1001,
                Name = "Pranaya",
                Department = "IT"
            };
            IsInserted = AddEmployee(employee2);
            Console.WriteLine($"Is Employee with id 1002 inserted: {IsInserted}");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        public static bool AddEmployee(Employee request)
        {
            var validationResult = IsRequestValid();//ket guiiong BindingResult  java
            if (validationResult.isValid == false)
            {
                Console.Write($"{ nameof(validationResult.errorMessage)} : { validationResult.errorMessage}");
                return false;
            }
            // Some code for inserting the Employee in database.
            return true;
            (bool isValid, string errorMessage) IsRequestValid()
            {
                if (request == null)
                {
                    throw new ArgumentNullException(nameof(request), $"The { nameof(request) } can not be null.");
                }
                var lsb = new Lazy<StringBuilder>();
                if (string.IsNullOrWhiteSpace(request.Name))
                {
                    lsb.Value.AppendLine($"The {nameof(request)}’s {nameof(request.Name)} property can not be empty.");
                }
                if (string.IsNullOrWhiteSpace(request.Gender))
                {
                    lsb.Value.AppendLine($"The {nameof(request)}’s {nameof(request.Gender)} property can not be empty.");
                }
                if (string.IsNullOrWhiteSpace(request.Department))
                {
                    lsb.Value.AppendLine($"The {nameof(request)}’s {nameof(request.Department)} property can not be empty.");
                }
                if (request.Id <= 0)
                {
                    lsb.Value.AppendLine($"The {nameof(request)}’s {nameof(request.Id)} property can not be less than zero.");
                }
                if (request.Salary <= 0)
                {
                    lsb.Value.AppendLine($"The {nameof(request)}’s {nameof(request.Salary)} property can not be less than zero.");
                }
                if (lsb.IsValueCreated)
                {
                    var errorMessage = lsb.Value.ToString();
                    return (isValid: false, errorMessage: errorMessage);
                }
                return (isValid: true, errorMessage: string.Empty);
            }
        }
    }
    public class Employee
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public double Salary { get; set; }
        public string Department { get; set; }
    }
}

