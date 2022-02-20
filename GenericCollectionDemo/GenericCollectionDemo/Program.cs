using System;
using System.Collections.Generic;
using System.Collections;

namespace GenericCollectionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Createing an interger list
            //it is going to store only integer value
            List<int> integerList = new List<int>();
         
            Console.WriteLine("Initial Capacity: " + integerList.Capacity);
            integerList.Add(10);
            Console.WriteLine("Capacity after adding first item: " + integerList.Capacity);
            integerList.Add(20);
            integerList.Add(30);
            integerList.Insert(2,2000);
            integerList.Add(40);
            Console.WriteLine("Capacity after adding fourth item: " + integerList.Capacity);
            integerList.Add(60);
            Console.WriteLine("Capacity after adding 5th element: " + integerList.Capacity);
            //Printing the List items using for loop 
            Console.WriteLine("Printing the List items using for loop:");
            for (int i = 0; i < integerList.Count; i++)
            {
                Console.Write(integerList[i] + "  ");
            }
            Console.WriteLine();
            //Removing the values from the middle of the list
            //here we are removing by value
            integerList.Remove(30);
            //You can also remove element by using index position
            //integerList.RemoveAt(2);
            //Printing the list items using foreach loop after
            //removing an element from the collection
            Console.WriteLine("List items after removing the value 30 :");
            foreach (int item in integerList)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
            //inserting values into the middle of the list collection
            integerList.Insert(2, 25);
            // Printing the values of the collection using foreach loop after
            // inserting an element into the middle of the collection
            Console.WriteLine("List items after inserting the value 25 in the index 2");
            foreach (int item in integerList)
            {
                Console.Write(item + "  ");
            }
            Console.WriteLine();
            // creating new ArrayList collection by passing the old 
            // array list as parameter
            List<int> newIntegerList = new List<int>(integerList);
            Console.WriteLine("Initial capacity of new list collection:" + newIntegerList.Capacity);
            // Printing the values of the new list collection using foreach loop
            Console.WriteLine("Printing the new List items which is created from the old list");
            foreach (int item in newIntegerList)
            {
                Console.Write(item + "  ");
            }
            Console.ReadKey();
        }
    }
}
