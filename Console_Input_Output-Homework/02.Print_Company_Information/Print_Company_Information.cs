using System;

//Problem 2. Print Company Information

//    A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//    Write a program that reads the information about a company and its manager and prints it back on the console.

//Example input:
//program 	user
//Company name: 	Telerik Academy
//Company address: 	31 Al. Malinov, Sofia
//Phone number: 	+359 888 55 55 555
//Fax number: 	2
//Web site: 	http://telerikacademy.com/
//Manager first name: 	Nikolay
//Manager last name: 	Kostov
//Manager age: 	25
//Manager phone: 	+359 2 981 981

//Example output:

//Telerik Academy
//Address: 231 Al. Malinov, Sofia
//Tel. +359 888 55 55 555
//Fax: (no fax)
//Web site: http://telerikacademy.com/
//Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)  


class Print_Company_Information
{
    static bool Input(string what, out string where, char type)
    {


        Console.Write(what);
        where = Console.ReadLine();
        if (where == null || where == string.Empty) return (false);

        switch (type)
        {
            case '0': //dont touch input data
                break;
            case 'n':
                where = where.Substring(0, 1).ToUpper() + where.Substring(1).ToLower(); //first letter to upper
                break;
            case 'p':
                if (string.Compare(where, 0, "+359", 0, 4) != 0) where = "(no phone)"; //phones must start with +359
                break;
            case 'f':
                if (string.Compare(where, 0, "+359", 0, 4) != 0) where = "(no fax)"; //like phones
                break;
            case 'a':
                int tempInt;
                if (!int.TryParse(where, out tempInt) || (tempInt < 1 || tempInt > 130)) where = "(N/A)"; //age is not string and it is between 1 and 130
                break;
            case 'w':
                if (string.Compare(where, 0, "http", 0, 4) != 0) where = "(no web site)"; //website must start with http
                break;

        }

        return (true);
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        //Everything is in strings. We need do convert if other type is needed!
        //It is not so bad, because console input is in strings!

        string companyName;
        while (!Input("Company name: ", out companyName, '0'))
        {
            Console.WriteLine("error: Empty string or null string. Try again!");
        }

        string companyAddress;
        while (!Input("Company address: ", out companyAddress, 'n'))
        {
            Console.WriteLine("error: Empty string or null string. Try again!");
        }

        string phone;
        while (!Input("Phone number: ", out phone, 'p'))
        {
            Console.WriteLine("error: Empty string or null string. Try again!");
        }

        string fax;
        while (!Input("Fax number: ", out fax, 'p'))
        {
            Console.WriteLine("error: Empty string or null string. Try again!");
        }

        string webSite;
        while (!Input("Web site: ", out webSite, 'w'))
        {
            Console.WriteLine("error: Empty string or null string. Try again!");
        }

        string manFirstName;
        while (!Input("Manager first name: ", out manFirstName, 'n'))
        {
            Console.WriteLine("error: Empty string or null string. Try again!");
        }

        string manLastName;
        while (!Input("Manager last name: ", out manLastName, 'n'))
        {
            Console.WriteLine("error: Empty string or null string. Try again!");
        }

        string manAge;
        while (!Input("Manager age: ", out manAge, 'a'))
        {
            Console.WriteLine("error: Empty string or null string. Try again!");
        }

        string manPhone;
        while (!Input("Manager phone: ", out manPhone, 'p'))
        {
            Console.WriteLine("error: Empty string or null string. Try again!");
        }


        //Telerik Academy
        //Address: 231 Al. Malinov, Sofia
        //Tel. +359 888 55 55 555
        //Fax: (no fax)
        //Web site: http://telerikacademy.com/
        //Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)

        Console.WriteLine();
        Console.WriteLine(companyName);
        Console.WriteLine("Address: " + companyAddress);
        Console.WriteLine("Tel. " + phone);
        Console.WriteLine("Fax. " + fax);
        Console.WriteLine("Web  site: " + webSite);
        Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", manFirstName, manLastName, manAge, manPhone);
    }
}
