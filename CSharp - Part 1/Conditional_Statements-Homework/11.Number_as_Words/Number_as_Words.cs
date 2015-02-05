using System;

//Problem 11.* Number as Words

//    Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.

//Examples:
//numbers 	number as words
//0 	Zero
//9 	Nine
//10 	Ten
//12 	Twelve
//19 	Nineteen
//25 	Twenty five
//98 	Ninety eight
//98 	Ninety eight
//273 	Two hundred and seventy three
//400 	Four hundred
//501 	Five hundred and one
//617 	Six hundred and seventeen
//711 	Seven hundred and eleven
//999 	Nine hundred and ninety nine

class Number_as_Words
{
    static string numberToWord(int digit)
    {
        switch (digit)
        {
            case 0:
                return ("zero");
            case 1:
                return ("one");
            case 2:
                return ("two");
            case 3:
                return ("three");
            case 4:
                return ("four");
            case 5:
                return ("five");
            case 6:
                return ("six");
            case 7:
                return ("seven");
            case 8:
                return ("eight");
            case 9:
                return ("nine");
            case 10:
                return ("ten");
            case 11:
                return ("eleven");
            case 12:
                return ("twelve");
            case 13:
                return ("thirteen");
            case 20:
                return ("twenty");
            case 30:
                return ("thirty");
            case 40:
                return ("fourty");
            case 50:
                return ("fifty");
            default:
                return ("not a digit");

        }
    }


    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        int number = 0;
        Console.Write("Enter number between 0 and 999 here: ");
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0 || number > 999) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(number));

        int one, ten, hundred;

        one = number % 10;
        number /= 10;
        ten = number % 10;
        number /= 10;
        hundred = number % 10;

        string words = string.Empty;

        if (hundred != 0) words = numberToWord(hundred) + " hundred";
        if (hundred != 0 && (ten > 0 || one > 0)) words += " and ";

        if (ten * 10 + one <= 13)
        {
            if (hundred != 0 && one != 0) words += numberToWord(ten * 10 + one);
            else
                if (hundred == 0) words += numberToWord(ten * 10 + one);
        }
        else
        {
            if (ten == 1)
            {
                if (one != 8) words += numberToWord(one) + "teen";
                else words += numberToWord(one) + "een";
            }
            else
                if (ten <= 5 && one == 0) words += numberToWord(ten * 10);
                else
                {
                    if (ten <= 5 && one != 0) words += numberToWord(ten * 10) + " " + numberToWord(one);
                    if (ten > 5 && one == 0)
                    {
                        if (ten != 8) words += numberToWord(ten) + "ty";
                        else words += numberToWord(ten) + "y";
                    }
                    if (ten > 5 && one > 0)
                    {
                        if (ten != 8) words += numberToWord(ten) + "ty " + numberToWord(one);
                        else words += numberToWord(ten) + "y " + numberToWord(one);
                    }
                }

        }


        words = words[0].ToString().ToUpper() + words.Substring(1);
        Console.WriteLine(words);

    }
}
