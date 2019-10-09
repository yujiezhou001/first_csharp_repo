using System;
using NonPrimitives.Math;

namespace NonPrimitives
{
    public enum ShippingMethod
    {
        RegularAirMail = 1,
        RegisteredAirMail = 2,
        Express = 3
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Smith";
            john.introduce();
            Calculator calculator = new Calculator();
            var result = calculator.Add(10, 20);
            Console.WriteLine(result);

            int[] array = new int[3];
            array[0] = 1;
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            Console.WriteLine(array[2]);

            bool[] array2 = new bool[2];
            array2[0] = true;
            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);

            var array3 = new int[2] { 1, 2 };
            Console.WriteLine(array3[1]);

            //string format
            string firstname = "Yujie";
            string lastname = "Zhou";
            //string[] names = new string[3] { "Yujie", "John", "Mary" };
            string[] names = { "Yujie", "John", "Mary" };
            var formattedNames = string.Join(",", names);
            Console.WriteLine(String.Format("My name is {0} {1}", firstname, lastname));
            Console.WriteLine(formattedNames);

            //enums
            //this is still in type enum
            var method = ShippingMethod.Express;
            //casting to integer
            Console.WriteLine((int)method);
            var methodId = 3;
            //casting back to enum
            Console.WriteLine((ShippingMethod)methodId);
            //convert enum to string
            //Console.WriteLine will still convert method to a string if not using ToString() method
            Console.WriteLine(method.ToString());
            //convert string to enum
            var methodName = "Express";
            //return type is object, so need to cast it into enum(ShippingMethod)
            var shippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), methodName);
            Console.WriteLine(shippingMethod);
        }
    }
}
