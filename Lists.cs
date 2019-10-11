using System;
using System.Collections.Generic;

namespace Lists
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //we use list when we don't know how many objects to store in the data structure

            //different methods of instance of List
            var numbers = new List<int>() { 1, 2, 3, 4 };

            //Add()
            numbers.Add(1);

            //AddRange()
            numbers.AddRange(new int[3] { 6, 7, 8 });

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
            //IndexOf()
            Console.WriteLine("Index of 1: " + numbers.IndexOf(1));
            Console.WriteLine("Last Index of 1: " + numbers.LastIndexOf(1));
            //Count
            Console.WriteLine("Number of elements in the list: " + numbers.Count);
            //Remove()
            //In C# we can't modify a collection in a foreach loop
            for (var i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == 1)
                {
                    numbers.Remove(numbers[i]);
                }
            }
            //foreach(var number in numbers)
            //{
            //    if (number == 1)
            //    {
            //        numbers.Remove(number);
            //    }

            //}
            Console.WriteLine("List that removed 1 from it: ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //Clear()
            Console.WriteLine("Effects of Clear(): ");
            numbers.Clear();
            Console.WriteLine("Number of elements in the list after clear: " + numbers.Count);

        }
    }
}
