using System;
using System.Collections.Generic;
using System.Linq;

namespace NETFinalGeneric
{
    class Program
    {
        //Que: Write a generic class that meets the following requirements:
        //1)    That constrains a developer to only instantiate the class based on value types
        //2)    Contains a private generic collection
        //3)    Has a method to add items to the private collection
        //4)    Has a method that will return an item from the list(e.g.item 3 or item 4 in the list)
        //5)    Has a method that returns a sorted collection with the items in descending order
        static void Main(string[] args)
        {
            CustomList<int> mycustomlist = new CustomList<int>();
            mycustomlist.Add(45);
            mycustomlist.Add(54);
            mycustomlist.Add(24);
            mycustomlist.Add(12);
            mycustomlist.Add(87);
            Console.WriteLine($"Index of the Item 12 is: {mycustomlist.Return(12)} ");

            foreach (var item in mycustomlist.mylist)
            {
                Console.WriteLine($"Item in List: {item}");
            }

            Console.WriteLine("After Sorting in descending");
            foreach (var item in mycustomlist.SortedDescending())
            {
                Console.WriteLine($"Item in the List: {item}");
            }

        }
        
        public class CustomList<T> where T : struct
        {
            public List<T> mylist = new List<T>();
            public void Add(T item)
            {
                mylist.Add(item);
            }
            public int Return(T item)
            {
                return mylist.IndexOf(item);
            }

            public IEnumerable<T> SortedDescending()
            {
                return mylist.OrderByDescending(e => e);
            }
        }

    }
}
