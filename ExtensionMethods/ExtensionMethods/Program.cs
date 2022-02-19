using System;
using System.Linq;

namespace ExtensionMethods
{
    public class OldClass
    {
        public int x = 100;
        public void Test1()
        {
            Console.WriteLine("Method one: " + this.x);
        }
        public void Test2()
        {
            Console.WriteLine("Method two: " + this.x);
        }
    }

    public static class NewClass
    {
        public static void Text3(this OldClass O)
        {
            Console.WriteLine("Method Three");
        }
        public static void Text4(this OldClass O, int x)
        {
            Console.WriteLine("Method Four: " + x);
        }
        public static void Text5(this OldClass O)
        {
            Console.WriteLine("Method Five:" + O.x);
        }
    }

  
        public static class StringExtension
        {
            public static int GetWordCount(this string inputstring)
            {
                if (!string.IsNullOrEmpty(inputstring))
                {
                    string[] strArray = inputstring.Split(' ');
                    return strArray.Count();
                }
                else
                {
                    return 0;
                }
            }
        }


    public class Program
    {
        static void Main(string[] args)
        {
            //OldClass obj = new OldClass();
            //obj.Test1();
            //obj.Test2();
            ////Calling exrension methods
            //obj.Text3();
            //obj.Text4(10);
            //obj.Text5();
            //Console.ReadLine();

            string myWord = "Welcome to Dotnet Tutorials Extension Methods Article";
            int wordCount = myWord.GetWordCount();
            Console.WriteLine("string : " + myWord);
            Console.WriteLine("Count : " + wordCount);
            Console.Read();
        }
    }
}
