using System;
using System.Collections.Generic;

namespace Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var sentence = "This is going to be a really really really really really long text.";
            // call the static method defined below
            var summary = StringUtility.SummerizeTest(sentence, 25);
            Console.WriteLine(summary);

            // trim elinimates blackspace before and after the string"
            var fullName = "Yujie Zhou ";
            // string is immutable, so these methods create new string
            Console.WriteLine("Trim: '{0}'", fullName.Trim());

            Console.WriteLine("ToUpper: '{0}'", fullName.ToUpper());

            //split the string

            //first method
            var index = fullName.IndexOf(' ');
            var firstName = fullName.Substring(0, index);
            var lastName = fullName.Substring(index + 1);

            Console.WriteLine("FirstName: " + firstName);
            Console.WriteLine("LasttName: " + lastName);

            //second method
            var names = fullName.Split(' ');
            Console.WriteLine("FirstName: " + names[0]);
            Console.WriteLine("LasttName: " + names[1]);

            //replace
            Console.WriteLine("first replace: " + fullName.Replace("Yujie", "Gordon"));
            Console.WriteLine("second replace: " + fullName.Replace(" ", ""));

            //Validation
            //isNullOrEmpty: takes care of null and ""
            //isNullOrWhiteSpace: further takes care of blanks"

            if (String.IsNullOrWhiteSpace(" "))
                Console.WriteLine("Invalid");

            // if this is an input from user
            var str = "25";
            var age = Convert.ToByte(str);
            Console.WriteLine(age);

            float price = 29.95f;
            //to currency and with 0 decimal
            Console.WriteLine(price.ToString("C0"));

            }

       
        // declare another static method
        // function that summarizes text
        // maxLength = 20 is the default value
        
            
        
    }
}
