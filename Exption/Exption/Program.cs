using System;
namespace Exption
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Thao";
            //Console.WriteLine(name);
            //Console.Write("WELCOME " + name);
            //Console.ReadKey();

            //int a, b, c;
            //Console.WriteLine("ENTER TWO NUMBER");
            //Console.Write("Nhap so thu 1 : ");
            //a = int.Parse(Console.ReadLine());
            //Console.Write("Nhap so thu 2 : ");
            //b = Convert.ToInt32(Console.ReadLine());
            //c = a + b;
            //Console.WriteLine("THE SUM IS :" + c);
            //Console.WriteLine("THE SUM IS : " + (a + b));
            //Console.ReadKey();

            //int EID, SALARY;
            //string ENAME, ADDRESS, JOB;
            //Console.WriteLine("ENTER THE EMPLOYEE DTAILS");
            //Console.WriteLine("ENTER THE EMPLOYEE ID");
            //EID = int.Parse(Console.ReadLine());
            //Console.WriteLine("ENTER THE EMPLOYEE NAME");
            //ENAME = Console.ReadLine();
            //Console.WriteLine("ENTER THE EMPLOYEE SALARY");
            //SALARY = int.Parse(Console.ReadLine());
            //Console.WriteLine("ENTER THE EMPLOYEE ADDRESS ");
            //ADDRESS = Console.ReadLine();
            //Console.WriteLine("ENTER THE EMPLOYEE JOB");
            //JOB = Console.ReadLine();
            //Console.WriteLine("\n\n\nTHE EMPLOYEE DETAILS ARE GIVEN BELOW :");
            //Console.WriteLine("THE EMPLOYEE ID IS: " + EID);
            //Console.WriteLine("THE EMPLOYEE NAME IS: " + ENAME);
            //Console.WriteLine("THE EMPLOYEE SALARY IS: " + SALARY);
            //Console.WriteLine("THE EMPLOYEE ADDRESS IS: " + ADDRESS);
            //Console.WriteLine("THE EMPLOYEE JOB IS: " + JOB);
            //Console.ReadKey();

            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.White;
            //Console.Title = "Understanding Console Class";

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Title = "Understanding Console Class";

            int diem1, diem2, diem3 ;
            string SName;

            Console.Write("Nhap ten hoc sinh : ");
            SName = Console.ReadLine();

            Console.Write("Nhap dien 1 : ");
            diem1 = int.Parse(Console.ReadLine());
            Console.Write("Nhap dien 2 : ");
            diem2 = int.Parse(Console.ReadLine());
            Console.Write("Nhap dien 3 : ");
            diem3 = int.Parse(Console.ReadLine());


            Console.WriteLine("Tên của học sinh là : " + SName);
            Console.WriteLine("Tong la : " + (diem1 +diem2 +diem3 ));
            Console.WriteLine("TB  la : " + ((diem1 + diem2 + diem3)/3));
            Console.ReadKey();



        }


    }
}
