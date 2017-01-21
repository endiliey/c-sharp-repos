using System;

namespace DateTimePractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var dateTime = new DateTime(2015, 1, 1);
            var now = DateTime.Now;
            var today = DateTime.Today;
            Console.WriteLine(now.Hour);
            Console.WriteLine(now.Minute);

            var tommorrow = now.AddDays(1);
            var yesterday = now.AddDays(-1);
            var nexthour = now.AddHours(1);

            Console.WriteLine(now.ToLongDateString());
            Console.WriteLine(now.ToLongTimeString());
            Console.WriteLine(now.ToShortDateString());
            Console.WriteLine(now.ToString("yyyy MMMM dd"));





        }
    }
}
