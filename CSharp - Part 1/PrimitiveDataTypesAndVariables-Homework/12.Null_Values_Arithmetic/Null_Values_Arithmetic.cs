using System;

//Problem 12. Null Values Arithmetic

//    Create a program that assigns null values to an integer and to a double variable.
//    Try to print these variables at the console.
//    Try to add some number or the null literal to these variables and print the result.


class Null_Values_Arithmetic
{
    static void Main()
    {
        int? nullValueInt = null;
        double? nullValueDbl = null;
        Console.WriteLine("Int-null value is [{0}], and double-null value is [{1}]", nullValueInt, nullValueDbl);
        nullValueInt++;
        nullValueDbl++;
        Console.WriteLine("After ++ int-null value is [{0}], and double-null value is [{1}]", nullValueInt, nullValueDbl);
        nullValueInt += null;
        nullValueDbl += (double?)null;
        Console.WriteLine("After ++ and +null int-null value is [{0}], and double-null value is [{1}]", nullValueInt, nullValueDbl); // They are still empty! Debugger says this too!

        nullValueInt = 1;
        nullValueDbl = 1d;
        nullValueInt += null;
        nullValueDbl += (double?)null;
        Console.WriteLine("After setting a value and +null int-null value is [{0}], and double-null value is [{1}]", nullValueInt, nullValueDbl); //Well after adding null, they become empty again!

    }
}

