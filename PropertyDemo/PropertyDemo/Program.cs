using System;

namespace PropertyDemo
{


    //    public class Explams
    //    {
    //         int num1, num2 , result;

    //        public int setnum1
    //        {
    //            set
    //            {
    //                num1 = value;
    //            }
    //        }

    //        public int setnum2
    //        {
    //            set
    //            {
    //                num2 = value;
    //            }

    //        }

    //        public int resultCaculator
    //        {
    //            get
    //            {
    //                return result;
    //            }
    //        }

    //        public void add()
    //        {
    //            result = num1 + num2;
    //        }
    //    }
    //    class Program
    //    {
    //        static void Main(string[] args)
    //        {
    //            Explams obj = new Explams();
    //            obj.setnum1 = 1;
    //            obj.setnum2 = 10;
    //            obj.add();
    //            Console.WriteLine(obj.resultCaculator);
    //            Console.ReadKey();
    //        }
    //    }

    public class Student
    {
        private int _id;
        private string _name;
        private int _passMark = 35;
        public int ID
        {
            set
            {
                if (value < 0)
                {
                    throw new Exception("ID value should be greater than zero");
                }
                this._id = value;
            }
            get
            {
                return this._id;
            }
        }
        public string Name
        {
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Name should not be empty");
                }
                this._name = value;
            }
            get
            {
                return string.IsNullOrEmpty(this._name) ? "No Name" : this._name;
            }
        }
        public int PassMark
        {
            get
            {
                return this._passMark;
            }
        }
    }


   //y duc Java
    public class Customer{
        private string name;
        private int age;
         

        public Customer(string name , int age)
        {
            this.name = name;
            this.age = age;
        }
        public string getName()
        {
            return name;
        }

        public int getAge()
        {
            return age;
        }

        }
    class Program
    {
        static void Main(string[] args)
        {
            Student S = new Student();
            S.ID = 101;
            S.Name = "Pranaya";
            Console.WriteLine("Student ID = {0}", S.ID);
            Console.WriteLine("Student Name = {0}", S.Name);
            Console.WriteLine("Studenr Pass Mark = {0}", S.PassMark);

            Customer C = new Customer("Nam", 19);

            Console.WriteLine("Customer name : {0} and {1} year old", C.getName() , C.getAge());

            Console.ReadKey();


        }
    }
}

