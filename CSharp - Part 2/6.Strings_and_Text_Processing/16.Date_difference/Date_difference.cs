//Problem 16. Date difference

//    Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.

//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days

//27.02.2006
//3.03.2006

namespace _16.Date_difference
{
    using System;

    class Date_difference
    {
        static DateTime PrsDate(string date)
        {
            string[] dates = date.Split('.');
            int[] intDates = new int[dates.Length];

            for (int i = 0; i < dates.Length; i++)
            {
                intDates[i]= int.Parse(dates[i]);
            }
            DateTime DT = new DateTime(intDates[2],intDates[1],intDates[0]);
            return(DT);
        }

        static void Main()
        {
            Console.WriteLine("format: day.month.year");
            Console.WriteLine("Enter the first date:");
            string firstDate = Console.ReadLine();
            Console.WriteLine("Enter the second date:");
            string secondDate = Console.ReadLine();

            DateTime firstDT = PrsDate(firstDate);
            DateTime secondDT = PrsDate(secondDate);
            TimeSpan distance = secondDT - firstDT;
            Console.WriteLine("Distance: {0:%d} day(s)", distance);
        }
    }
}
