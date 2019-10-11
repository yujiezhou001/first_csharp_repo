using System;
using System.Linq;

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

            //calculate factorial
            Console.Write("Please enter a number: ");
            var input2 = Console.ReadLine();
            var number1 = Convert.ToInt32(input2);
            var factorial = 1;
            for (var i = 1; i <= number1; i++)
            {
                factorial *= i;
            }
            Console.WriteLine("Here's your factorial:" + factorial);

            //find max or min number from user input
            Console.Write("Please enter a series of number: ");
            var input3 = Console.ReadLine();
            //first approach
            //string[] nums = input3.Split(',');
            //var max = Convert.ToInt32(nums[0]);
            //for (var i = 0; i < nums.Length; i++)
            //{
            //    if (max < Convert.ToInt32(nums[i]))
            //    {
            //        max = Convert.ToInt32(nums[i]);
            //    }
            //}
            //Console.WriteLine(max);
            //second approach
            int[] nums = Array.ConvertAll(input3.Split(','), int.Parse);
            int max = nums.Max();
            int min = nums.Min();
            Console.WriteLine("Here's your maximum number:" + max);

            //calculate number of divisible numbers
            int count = 0;
            for (var i = 1; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine("There are {0} numbers between 1 and 100 that can be divisible by 3", count);

            //calculate sum through a small user prompt program
            int sum = 0;
            while (true)
            {
                Console.Write("Enter a number (or 'ok' to exit): ");
                var input4 = Console.ReadLine();
                if (input4.ToLower() == "ok")
                {
                    break;
                }
                var number = Convert.ToInt32(input4);
                sum += number;
                Console.WriteLine("Your current sum: " + sum);
            }
        }
    }
}

