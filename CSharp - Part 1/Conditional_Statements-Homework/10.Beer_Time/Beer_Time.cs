using System;

//Problem 10.* Beer Time

//    A beer time is after 1:00 PM and before 3:00 AM.
//    Write a program that enters a time in format “hh:mm tt” (an hour in range [01...12], a minute in range [00…59] and AM / PM designator) and prints beer time or non-beer time according to the definition above or invalid time if the time cannot be parsed. Note: You may need to learn how to parse dates and times.

//Examples:
//time 	result
//1:00 PM 	beer time
//4:30 PM 	beer time
//10:57 PM 	beer time
//8:30 AM 	non-beer time
//02:59 AM 	beer time
//03:00 AM 	non-beer time
//03:26 AM 	non-beer time

class Beer_Time
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        DateTime currentdate = DateTime.Now;
        Console.Write("Enter your birthday in this format [" + currentdate.ToString("h:mm tt") + "] here: ");

        string tempString = Console.ReadLine();
        while (tempString == null || tempString == string.Empty)
        {
            Console.Write("Please enter a string: ");
            tempString = Console.ReadLine();
        }

        DateTime parsedDate;

        if (DateTime.TryParseExact(tempString, "h:mm tt", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out parsedDate))
            if ((parsedDate.ToString("tt") == "PM" && parsedDate.Hour >= 1) || (parsedDate.ToString("tt") == "AM" && parsedDate.Hour < 3))
                Console.WriteLine("beer time");
            else Console.WriteLine("non-beer time");
        else Console.WriteLine("invalid time");
    }
}
