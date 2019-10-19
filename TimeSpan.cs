using System;

namespace timeSpan
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Creating
            var timeSpan = new TimeSpan(1, 2, 3);
            Console.WriteLine(timeSpan);

            var timeSpan1 = new TimeSpan(1, 0, 0);
            var timeSpan2 = TimeSpan.FromHours(1);
            Console.WriteLine("first method: " + timeSpan1);
            Console.WriteLine("second method: " + timeSpan2);

            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            var duration = end - start;
            Console.WriteLine("Duration: " + duration);

            // Properties
            Console.WriteLine("Minutes: " + timeSpan.Minutes);
            Console.WriteLine("Total Minutes: " + timeSpan.TotalMinutes);

            // Add
            Console.WriteLine("Add Example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
            //Subtract
            Console.WriteLine("Subtract Example: " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));

            // ToString (Convert timespan to string value. Console.WriteLine() does it by default)
            Console.WriteLine("ToString: " + timeSpan.ToString());

            // Parse
            Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));

        }
    }
}
