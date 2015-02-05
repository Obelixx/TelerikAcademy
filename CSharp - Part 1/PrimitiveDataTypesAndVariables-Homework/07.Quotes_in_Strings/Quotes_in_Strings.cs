using System;

//Problem 7. Quotes in Strings

//    Declare two string variables and assign them with following value: The "use" of quotations causes difficulties.
//    Do the above in two different ways - with and without using quoted strings.
//    Print the variables to ensure that their value was correctly defined.

class Quotes_in_Strings
{
    static void Main()
    {
        string FirstVariable = "The \"use\" of quotations causes difficulties.";
        String SecondVariable = "The {0}use{0} of quotations causes difficulties.";
        Console.WriteLine("First string variable is: {0}", FirstVariable);
        Console.WriteLine("Second string variable is: " + SecondVariable, @""""); // Wow, this worked!
    }
}

