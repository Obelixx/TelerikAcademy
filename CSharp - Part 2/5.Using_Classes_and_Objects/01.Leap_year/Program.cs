//Problem 1. Leap year

//    Write a program that reads a year from the console and checks whether it is a leap one.
//    Use System.DateTime.


namespace _01.Leap_year
{
    using System;

    class Program
    {
        static void Main()
        {
            int year;
            Console.Write("Enter the year here: ");
            while(!int.TryParse(Console.ReadLine(),out year))
                Console.WriteLine("Input correct year!");

            DateTime parsedDate = new DateTime(year,1,1);


            if (DateTime.IsLeapYear(parsedDate.Year))
            {
                Console.WriteLine("Year {0} is leap year!",parsedDate.Year);
            }
            else
            {
                Console.WriteLine("Year {0} is not leap year!",parsedDate.Year);
            }



        }
    }
}
