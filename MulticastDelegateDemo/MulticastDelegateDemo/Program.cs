using System;

namespace MulticastDelegateDemo
{

    //// Deletegate has an int output parameter
    //public delegate void SampleDelegate(out int Integer);

    //public class Program
    //{
    //    static void Main()
    //    {
    //        SampleDelegate del = new SampleDelegate(MethodOne);
    //        del += MethodTwo;
    //        del += MethodThree;
    //        // The ValueFromOutPutParameter will be 2, initialized by MethodTwo(),
    //        // as it is the last method in the invocation list.
    //        int ValueFromOutPutParameter = -1;
    //        del(out ValueFromOutPutParameter);
    //        Console.WriteLine("Returned Value = {0}", ValueFromOutPutParameter);
    //        Console.ReadKey();
    //    }
    //    // This method sets ouput parameter Number to 1
    //    public static void MethodOne(out int Number)
    //    {
    //        Number = 1;
    //    }
    //    // This method sets ouput parameter Number to 2
    //    public static void MethodTwo(out int Number)
    //    {
    //        Number = 2;
    //    }

    //    public static void MethodThree(out int Number)
    //    {
    //        Number = 12;
    //    }
    //}

    public delegate void MathDelegate(int No1, int No2);
    public class Program
    {
        public static void Add(int x, int y)
        {
            Console.WriteLine("THE SUM IS : " + (x + y));
        }
        public static void Sub(int x, int y)
        {
            Console.WriteLine("THE SUB IS : " + (x - y));
        }
        public void Mul(int x, int y)
        {
            Console.WriteLine("THE MUL IS : " + (x * y));
        }
        public void Div(int x, int y)
        {
            Console.WriteLine("THE DIV IS : " + (x / y));
        }

        static void Main(string[] args)
        {
            Program p = new Program();
            MathDelegate del1 = new MathDelegate(Add);
            MathDelegate del2 = new MathDelegate(Program.Sub);
            // MathDelegate del3 = p.Mul;
            MathDelegate del3 = new MathDelegate(p.Mul);
            MathDelegate del4 = new MathDelegate(p.Div); ;
            //In this example del5 is a multicast delegate. We can use +(plus) 
            // operator to chain delegates together and -(minus) operator to remove.
            MathDelegate del5 = del1 + del2 + del3 + del4;
            del5.Invoke(20, 5);
            Console.WriteLine();
            del5 -= del2;
            del5(22, 7);

            Console.ReadKey();
        }
    }
}
