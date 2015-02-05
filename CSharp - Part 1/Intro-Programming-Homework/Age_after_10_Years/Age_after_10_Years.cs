using System;

//Problem 15.* Age after 10 Years
//    Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.

class Age_after_10_Years
{
    static void Main()
    {
        DateTime currentdate = DateTime.Now;
        //DateTime currentdate = DateTime.Parse("29.02.2012");
        Console.Write("Enter your birthday in this format " + currentdate.ToString("d") + " here: ");

        string tempString = Console.ReadLine();
        //string tempString = "13.01.2014";

        

        DateTime parsedDate;
        if (tempString != null)
            if (DateTime.TryParse(tempString, out parsedDate))

                if (currentdate.CompareTo(parsedDate) == 1)
                {
                    Console.WriteLine("Your burthday is: {0,17}", parsedDate.ToString("d"));
                    int age = currentdate.Year - parsedDate.Year;
                    if (currentdate.AddYears(-age) < parsedDate) age--;
                    Console.WriteLine("Your age: {0,25}", age);
                    Console.WriteLine("Your age after 10 years: {0,10}", age + 10);
                }
                else Console.WriteLine("Dont use future dates!");
            else Console.WriteLine("Use correct format and dates!");
        else Console.WriteLine("No empty strings, please!");
    }
}

