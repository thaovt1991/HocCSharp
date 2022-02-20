using System;

namespace DelegateDemoAnonymous
{
    public class AnonymousMethods
    {
        public delegate string GreetingsDelegate(string name);
        //public static string Greetings(string name)
        //{
        //    return "Hello @" + name + " Welcome to Dotnet Tutorials";
        //}
        static void Main(string[] args)
        {

            string Message = " Welcome to Dotnet Tutorials";
            // GreetingsDelegate gd = new GreetingsDelegate(AnonymousMethods.Greetings);
           
            // phuong thuc an danh
            //GreetingsDelegate gd = delegate(string name)
            //{
            //    return "Hello @" + name + " " + Message;
            //};


            // lambda expressions
            GreetingsDelegate gd = (name)=>
            {
                return "Hello @" + name + " " + "Welcome to Dotnetzdasdsdsadasdasdsadasdasdsadas";
            };


            string GreetingsMessage = gd.Invoke("Pranaya");
            Console.WriteLine(GreetingsMessage);
            Console.ReadKey();
        }
    }
}
