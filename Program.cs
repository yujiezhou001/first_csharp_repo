using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
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
            //Console.WriteLine("parse uncompatible types {0}", output2);
            //Console.WriteLine(output3);
            //Console.WriteLine(b);
        }
    }
}
