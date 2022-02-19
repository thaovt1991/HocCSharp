using System;

namespace UnderstandingObjectClassMethods
{
   public class Customer
    {
        private string name, address;
        private int age;

        public string Address { get => address; set => address = value; }
        public int Age { get => age; set => age = value; }

        public Customer()
        {

        }
        public Customer(string name , string address, int age)
        {
            this.name = name; this.Address = address; this.Age = age;
        }

        public void setName(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return name;
        }


    }
      
}
