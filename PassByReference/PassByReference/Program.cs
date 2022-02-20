using System;

namespace PassByReference
{
    class Program
    {
        //    static void Main(string[] args)
        //    {
        //        // int testOut = 10;
        //        int no = 1; 
        //        PassByReference(ref no);// can khoi tao tham so truoc
        //        Out(out int  testOut); // co the create trong ham vua creat va truyeefn vafo
        //        Console.WriteLine($"After the invocation of {nameof(PassByReference)} method, {nameof(no)} = {no}");
        //        Console.WriteLine($"After the invocation of {nameof(Out)} method, {nameof(testOut)} = {testOut}");
        //        int no1 = 1;
        //        ref int no2 = ref no1;
        //        no2 = 2;
        //        Console.WriteLine($"local variable {nameof(no1)} after the change: {no1}");


        //        Console.WriteLine("Press any key to Exit.");
        //        Console.ReadLine();
        //    }
        //    static void PassByReference(ref int x)
        //    {
        //        x = 2;
        //    }
        //    static void Out(out int x)
        //    {
        //        x = 20;
        //    }
        //}
        public ref int GetFirstOddNumber(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 1)
                {
                    return ref numbers[i]; //returning as reference  
                }
            }
            throw new Exception("odd number not found");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            int[] x = { 2, 4, 62, 54, 33, 55, 66, 71, 92 };
            ref int oddNum = ref p.GetFirstOddNumber(x); //storing as reference  
            Console.WriteLine($"\t\t{oddNum}"); //\t tang khoan cach len 1 khaong
            oddNum = 35;
            for (int i = 0; i < x.Length; i++)
            {
                Console.Write($"{x[i]}\t");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to exist.");
            Console.ReadKey();
        }
    }
}