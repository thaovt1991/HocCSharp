using System;
using System.IO;

namespace ExceptionHandlingDemo
{

    class Program
    {
        public static void Main()
        {
            try
            {
                try
                {
                    //throw new ArgumentException();
                    Console.WriteLine("Enter First Number");
                      int FN = Convert.ToInt32(Console.ReadLine());
                 // int FN = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int SN = Convert.ToInt32(Console.ReadLine());
                   // int SN = int.Parse(Console.ReadLine());
                    int Result = FN / SN;
                    Console.WriteLine("Result = {0}", Result);
                }
                catch (Exception ex)
                {
                    //make sure this path does not exist
                    string filePath = @"E:\LogFile\Log.txt";
                    if (!File.Exists(filePath))
                    {
                        StreamWriter sw = new StreamWriter(filePath);
                        sw.Write(ex.GetType().Name + ex.Message + ex.StackTrace);
                        sw.Close();
                        Console.WriteLine("There is a problem! Please try later");
                    }
                    else
                    {
                        //To retain the original exception pass it as a parameter
                        //to the constructor, of the current exception
                        throw new FileNotFoundException(filePath + " Does not Exist", ex);
                    }
                }
            }
            catch (Exception e)
            {
                //e.Message will give the current exception message
                Console.WriteLine("Current or Outer Exception = " + e.Message);
                //Check if inner exception is not null before accessing Message property
                //else, you may get Null Reference Excception
                if (e.InnerException != null)
                {
                    Console.Write("Inner Exception : ");
                    Console.WriteLine(String.Concat(e.InnerException.StackTrace, e.InnerException.Message));
                }
            }
            Console.ReadLine();
        }
    }
}
