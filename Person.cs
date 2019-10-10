using System;
namespace NonPrimitives
{
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int Age;
        public void introduce()
        {
            Console.WriteLine("My name is " + FirstName + " " + LastName);
        }
    }
}
