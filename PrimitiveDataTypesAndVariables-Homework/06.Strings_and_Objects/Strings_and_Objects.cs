using System;

//Problem 6. Strings and Objects

//    Declare two string variables and assign them with Hello and World.
//    Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//    Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).


class Strings_and_Objects
{
    static void Main()
    {
        string hi = "Hallo";
        string world = "World";
        object hiWorld = hi + " " + world;
        string variable = (string)hiWorld;
        Console.WriteLine(variable);  //ok, works fine!
    }
}

