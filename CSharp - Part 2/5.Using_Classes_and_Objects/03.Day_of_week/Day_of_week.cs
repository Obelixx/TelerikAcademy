//Problem 3. Day of week

//    Write a program that prints to the console which day of the week is today.
//    Use System.DateTime.

namespace _03.Day_of_week
{
    using System;

    class Day_of_week
    {
        static void Main()
        {
            DateTime now = DateTime.Now;
            Console.WriteLine("Today is: " + now.AddDays(4).DayOfWeek);
        }
    }
}
