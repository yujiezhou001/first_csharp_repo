using System;

namespace Iteration
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //foreach loop
            int[] numbers = { 1, 2, 3, 4 };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            //for loop
            var firstName = "John Smith";
            for (var i = 0; i < firstName.Length; i++)
            {
                Console.WriteLine(firstName[i]);
            }

            //while loop
            var j = 0;
            while (j <= 10)
            {
                if (j % 2 == 0)
                {
                    Console.WriteLine(j);
                }

                j++;
            }

            //while loop with break and continue5
            while (true)
            {
                //first game
                Console.Write("Type your name to enter the first game here:");
                var input = Console.ReadLine();

                if (String.IsNullOrEmpty(input))
                {
                    break;
                }

                Console.WriteLine("You've entered the first echo game, @Echo: {0}", input);

                //second game
                Console.Write("Type your name to enter the second game here:");
                var input1 = Console.ReadLine();
                if (!String.IsNullOrEmpty(input1))
                {
                    Console.WriteLine("You've entered the second echo game. @Echo: {0}, the first game will start again", input1);
                    continue;//this will help the game get back to while loop while the if statement stands
                }

                break;//this will make the game occur only once if we don't have continue
            }

            //create random password
            var random = new Random();

            const int passwordLength = 10;

            char[] buffer = new char[passwordLength];
            

            for (var i = 0; i < passwordLength; i++)
            {
                buffer[i] = (char)('a' + random.Next(0, 26));
            }

            //convert array to string
            var password = new string(buffer);
            Console.WriteLine(password);
        }
    }
}
