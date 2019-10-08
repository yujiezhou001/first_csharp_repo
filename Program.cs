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

            string s = "1";
            int s1 = 1;
            int output1 = Convert.ToInt32(s);
            int output2 = int.Parse(s);
            char output3 = (char)s1;
            Console.WriteLine(output1);
            Console.WriteLine(output2);
            Console.WriteLine(output3);
        }
    }
}
