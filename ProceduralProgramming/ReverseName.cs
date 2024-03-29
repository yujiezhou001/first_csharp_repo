using System;

namespace ProceduralProgramming
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("What's your name? ");
            var name = Console.ReadLine();
            var reversed = ReverseName(name);
            Console.WriteLine("Reversed name: " + reversed);

            UniqueNumber.Unique();
        }

        public static string ReverseName(string name)
        {
            var array = new char[name.Length];
            for (var i = name.Length; i > 0; i--)
                array[name.Length - i] = name[i - 1];

            return new string(array);
        }
    }
}
