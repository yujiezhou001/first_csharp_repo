using System;
using System.Text;

namespace stringBuilder
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // string builder doesn't have string search method
            var builder = new StringBuilder("Hello World");
            // since Append, Replace, Remove and Insert return stringbuilder, can chain them
            builder
                .Append('-', 10)
                .AppendLine()
                .Append("Header")
                .AppendLine()
                .Append('-', 10)
                .Replace('-', '+')
                .Remove(0, 10)
                .Insert(0, new String('-', 10));

            Console.WriteLine(builder);

            Console.WriteLine("First Char: " + builder[0]); 
        }
    }
}
