using System;

//Problem 2. Float or Double?

//    Which of the following values can be assigned to a variable of type float and which to a variable of type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//    Write a program to assign the numbers in variables and print them to ensure no precision is lost.



class Float_or_Double
{
    static void Main()
    {
        //34.567839023, 12.345, 8923.1234857, 3456.091?
        double typeFloat = 34.56783902d;
        float typeFloat1 = 12.345F;
        double typeFloat2 = 8923.1234857d;
        float typeFloat3 = 3456.091F;

        Console.WriteLine("Data Type for [{0,14}] is: [{1,16}]", typeFloat, typeFloat.GetType().ToString());
        Console.WriteLine("Data Type for [{0,14}] is: [{1,16}]", typeFloat1, typeFloat1.GetType().ToString());
        Console.WriteLine("Data Type for [{0,14}] is: [{1,16}]", typeFloat2, typeFloat2.GetType().ToString());
        Console.WriteLine("Data Type for [{0,14}] is: [{1,16}]", typeFloat3, typeFloat3.GetType().ToString());
    }
}

