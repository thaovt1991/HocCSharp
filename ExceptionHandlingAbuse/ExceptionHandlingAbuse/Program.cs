using System;

namespace ExceptionHandlingAbuse
{
    class Program
    {

        public static void Main()
        {
            try
            {
                Console.WriteLine("Please enter First Number");
                int FNO;
                //int.TryParse() will not throw an exception, instead returns false
                //if the entered value cannot be converted to integer
                bool isValidFNO = int.TryParse(Console.ReadLine(), out FNO);
                if (isValidFNO)
                {
                    Console.WriteLine("Please enter Second Number");
                    int SNO;
                    bool isValidSNO = int.TryParse(Console.ReadLine(), out SNO);

                    if (isValidSNO && SNO != 0)
                    {
                        int Result = FNO / SNO;
                        Console.WriteLine("Result = {0}", Result);
                    }
                    else
                    {
                        //Check if the second number is zero and print a friendly error
                        //message instead of allowing DivideByZeroException exception 
                        //to be thrown and then printing error message to the user.
                        if (isValidSNO && SNO == 0)
                        {
                            Console.WriteLine("Second Number cannot be zero");
                        }
                        else
                        {
                            Console.WriteLine("Only numbers between {0} && {1} are allowed",
                                Int32.MinValue, Int32.MaxValue);
                        }
                    }
                }
                else
                {
                    Console.WriteLine("loi sau");
                    Console.WriteLine("Only numbers between {0} && {1} are allowed",
                                Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
