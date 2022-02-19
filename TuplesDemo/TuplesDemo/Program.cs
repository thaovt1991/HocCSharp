using System;
using System.Collections.Generic;

namespace TuplesDemo
{
    class Program
    {
        // static void Main()
        // {
        //     var valueList = new List<double>() { 1, 1, 20, 24, 52, 6, 10 };
        //     var(lengthList, sumList, avgList ) = Calulate(valueList);


        //     Console.WriteLine($"Danh sach co so pghan tu la {lengthList} , tong laf  {sumList} , trung binh la {avgList}");
        //     Console.ReadKey();
        // }

        //private static (int count, double sum, double avg) Calulate(IEnumerable<double> valueList)
        // {
        //     int count = 0;
        //     double sum = 0.0;
        //     foreach(var  value in valueList)
        //     {
        //         count += 1;
        //         sum += value;
        //     }

        //     double avg = sum / count;
        //     return (count, sum, avg);
        // }

        static void Main()
        {
            //khai bao bt

            //var EmployeeDetails = GetEmployeeDetails(1001);
            //var Name = EmployeeDetails.Item1;
            //var Salary = EmployeeDetails.Item2;
            //var Gender = EmployeeDetails.Item3;
            //var Dept = EmployeeDetails.Item4;


            // khai bao chuoi cac gia trij  + thuoc tinsh 
            //    (string Name, double Salary, string Gender, string Dept) = GetEmployeeDetails(1001);
            // dung var khai bao
          //  var (Name, Salary, Gender, Dept) = GetEmployeeDetails(1001);
            //Bạn có thể giải cấu trúc bộ giá trị thành các biến đã được khai báo


            string Name;
            double Salary;
            string Gender = "Female";
            string Dept = "HR";
            (Name, Salary, Gender, Dept) = GetEmployeeDetails(1001);
            // Do something with the data.
            //here we are just printing the data in the console
            Console.WriteLine("Employee Details :");
            Console.WriteLine($"Name: {Name},  Gender: {Gender}, Department: {Dept}, Salary:{Salary}");
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
        private static (string, double, string, string) GetEmployeeDetails(long EmployeeID)
        {
            //based on the EmployyeID get the data from a database
            //here we are hardcoded the value
            string EmployeeName = "Pranaya";
            double Salary = 2000;
            string Gender = "Male";
            string Department = "IT";
            return (EmployeeName, Salary, Gender, Department);
        }
    }
}
