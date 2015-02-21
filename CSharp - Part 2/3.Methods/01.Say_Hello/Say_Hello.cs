using System;

//Problem 1. Say Hello

//    Write a method that asks the user for his name and prints “Hello, <name>”
//    Write a program to test this method.

//Example:
//input 	output
//Peter 	Hello, Peter!

class Say_Hello
{
    static void Say_hello()
    {
        string name = string.Empty;
        do
        {
            Console.Write("What is your name: ");
            name = Console.ReadLine();
        }
        while (name == string.Empty || name == null);

        name = name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower(); //make it look better for ppl not using big letters

        Console.WriteLine("Hallo, {0}!", name);
    }

    static void Main()
    {
        Say_hello();
    }
}

