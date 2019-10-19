using System;

namespace dateTime
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //a specific datetime
            var dateTime = new DateTime(2017, 10, 15);
            Console.WriteLine(dateTime);

            //current date and time
            var now = DateTime.Now;
            Console.WriteLine(now);
            Console.WriteLine("Hour: " + now.Hour);
            Console.WriteLine("Minute: " + now.Minute);
            var today = DateTime.Today;
            Console.WriteLine(today);

            //modify date and time
            var tomorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            Console.WriteLine("Tomorrow: " + tomorrow + "\nYesterday: " + yesterday);

            //different string formats
            Console.WriteLine("Long date string: " + now.ToLongDateString());
            Console.WriteLine("Short date string: " + now.ToShortDateString());
            Console.WriteLine("Long time string: " + now.ToLongTimeString());
            Console.WriteLine("Short time string: " + now.ToShortTimeString());

            //custom string formats
            Console.WriteLine("custom: " + now.ToString("yyyy-MM-dd HH:mm:ss"));
        }
    }
}
