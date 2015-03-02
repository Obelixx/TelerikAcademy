
//Problem 17. Date in Bulgarian

//    Write a program that reads a date and time given in the format:
// day.month.year hour:minute:second and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.

// 01.03.2015 23:14:30

namespace _17.Date_in_Bulgarian
{
    using System;

    class Date_in_Bulgarian
    {
        static DateTime PrsDateTime(string date)
        {
            string[] dates = date.Split('.',' ',':');
            int[] intDates = new int[dates.Length];

            for (int i = 0; i < dates.Length; i++)
            {
                intDates[i] = int.Parse(dates[i]);
            }
            DateTime DT = new DateTime(intDates[2], intDates[1], intDates[0],intDates[3],intDates[4],intDates[5]);
            return (DT);
        }

        static void Main()
        {
            Console.WriteLine("day.month.year hour:minute:second");
            Console.WriteLine("Enter the date:");
            string date = Console.ReadLine();

            var dt = PrsDateTime(date);

            var dtAfter = dt.AddHours(6d).AddMinutes(30d);
            Console.Write("after 6 hours and 30 minutes (in the same format): ");
            Console.WriteLine(dtAfter.ToString("dd.MM.yyyy HH:mm:ss"));

            Console.Write("the day of week in Bulgarian: ");

            var culture = new System.Globalization.CultureInfo("bg-BG");
            var Day = culture.DateTimeFormat.GetDayName(dtAfter.DayOfWeek);
            Console.WriteLine(Day);


        }
    }
}
