using System;

namespace Arrays
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //different methods on array class
            int[] numbers = { 10, 8, 12, 0, 0, 3, 4 };
            //Length
            Console.WriteLine("The length of array is: " + numbers.Length);
            //IndexOf()
            int index = Array.IndexOf(numbers, 12);
            Console.WriteLine("The index of 12 in array is: " + index);
            //Clear()
            //Clear() for boolean array turn them to false
            //Clear() for string array turn them to null
            Array.Clear(numbers, 5, 2);
            Console.WriteLine("Effect of Clear(): ");
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            //Copy()
            Console.WriteLine("Effect of Copy(): ");
            var destination = new int[3];
            Array.Copy(numbers, destination, 3);
            foreach (var number in destination)
            {
                Console.WriteLine(number);
            }
            //Sort()
            Console.WriteLine("Effect of Sort(): ");
            Array.Sort(numbers);
            foreach( var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
