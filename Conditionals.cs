using System;

namespace Conditionals
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool isGoldCustomer = true;

            float price = (isGoldCustomer) ? 19.95f : 29.95f;

            Console.WriteLine("This is your price: ${0}", price);

            var season = Season.Summer;

            switch (season)
            {
                case Season.Autumn:
                    Console.WriteLine("Maple leafs are turning red.");
                    break;
                //if it's spring or summer: same condition
                case Season.Spring:
                case Season.Summer:
                    Console.WriteLine("Everything's turnin' into boilers");
                    break;

                default:
                    Console.WriteLine("Guess which season is it now");
                    break;
            }

            //question number 4 from  exercise (speed camera problem):

            /* Write a program that asks the user to enter the speed limit.
             * Once set, the program asks for the speed of a car.
             * If the user enters a value less than the speed limit,
             * program should display Ok on the console.
             * If the value is above the speed limit,
             * the program should calculate the number of demerit points.
             * For every 5km/hr above the speed limit, 1 demerit points should be incurred and displayed on the console.
             * If the number of demerit points is above 12, the program should display License Suspended.
            */

            string input1;
            Console.Write("Please enter a speed limit(integer): ");
            input1 = Console.ReadLine();
            int speedLimit = Convert.ToInt32(input1);
            string input2;
            Console.WriteLine("Please enter your car speed(integer): ");
            input2 = Console.ReadLine();
            int carSpeed = Convert.ToInt32(input2);
            if (speedLimit < carSpeed)
            {
                int demeritPoints = (carSpeed - speedLimit) / 5;

                switch (demeritPoints)
                {
                    case int n when (n <= 12):
                        Console.WriteLine("You have {0} demerit points", demeritPoints);
                        break;

                    case int n when (n > 12):
                        Console.WriteLine("liscense Suspended");
                        break;
                }
                //    if (demeritPoints <= 12)
                //    {
                //        Console.WriteLine("You have {0} demerit points", demeritPoints);
                //    }

                //    if (demeritPoints > 12)
                //    {
                //        Console.WriteLine("License Suspended");
                //    }
            }
            else
            {
                Console.WriteLine("You're not over speed limit");
            }


        }
    }
}
