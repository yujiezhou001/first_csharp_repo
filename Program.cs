using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            //Primitive Types
            const float number = 1.0f;
            int output = (int)number;
            Console.WriteLine(output);
            try
            {
                string str = "true";
                bool b = Convert.ToBoolean(str);
                Console.WriteLine(b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("The string could not be converted to a boolean");
            }
            try
            {
                string p = "1234";
                byte p1 = Convert.ToByte(p);
                Console.WriteLine(p1);
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("The number could not be converted to a byte");
            }




            //int i = 1000;
            //byte b = (byte)i;
            //string s = "1";
            //int s1 = 1;
            //int output1 = Convert.ToInt32(s);
            //int output2 = int.Parse(s);
            //char output3 = (char)s1;
            //Console.WriteLine(output1);
            //Console.WriteLine("parse imcompatible types {0}", output2);
            //Console.WriteLine(output3);
            //Console.WriteLine(b);

            //Operators
            //Arithmetic Operators
            var firstnum = 10;
            var secondnum = 3;
            Console.WriteLine((float)firstnum / (float)secondnum);
            //Comparison Operators
            var num1 = 10;
            var num2 = 3;
            var num3 = 11;
            Console.WriteLine(num2 == num1 || num3 > num1); //True
            Console.WriteLine(num1 == num2); //Flase
            Console.WriteLine(num1 > num2); //True
            Console.WriteLine(num1 != num2); //True
            Console.WriteLine(num3 > num1 && num3 > num2); //True
        }
    }
}
