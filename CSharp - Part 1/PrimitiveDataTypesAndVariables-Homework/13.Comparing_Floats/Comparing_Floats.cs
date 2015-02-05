using System;

//Problem 13.* Comparing Floats

//    Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.

//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic. Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.

//Examples:
//Number a 	Number b 	Equal (with precision eps=0.000001) 	Explanation
//5.3 	6.01 	false 	The difference of 0.71 is too big (> eps)
//5.00000001 	5.00000003 	true 	The difference 0.00000002 < eps
//5.00000005 	5.00000001 	true 	The difference 0.00000004 < eps
//-0.0000007 	0.00000007 	true 	The difference 0.00000077 < eps
//-4.999999 	-4.999998 	false 	Border case. The difference 0.000001 == eps. We consider the numbers are different.
//4.999999 	4.999998 	false 	Border case. The difference 0.000001 == eps. We consider the numbers are different.

class Comparing_Floats
{
    static void Main()
    {
        double a;
        double b;
        double eps = 0.000001;

        Console.WriteLine("Precioson is:  {0,12}\nin other words:{1,12}\n", eps, eps.ToString("0.000000"));

        a = 5.3d;//	false
        b = 6.01d;
        Console.WriteLine("{0,12} == {1,12} is {2,12}  - {3,5}"
            , a
            , b
            , (a - b < 0) ? (b - a < eps) : (a - b < eps)
            , ((a - b < 0) ? (b - a < eps) == false : (a - b < eps) == false) ? "OK!" : "Not OK :/");

        a = 5.00000001d; //true
        b = 5.00000003d;
        Console.WriteLine("{0,12} == {1,12} is {2,12}  - {3,5}"
            , a
            , b
            , (a - b < 0) ? (b - a < eps) : (a - b < eps)
            , ((a - b < 0) ? (b - a < eps) == true : (a - b < eps) == true) ? "OK!" : "Not OK :/");

        a = 5.00000005d; //true
        b = 5.00000001d;
        Console.WriteLine("{0,12} == {1,12} is {2,12}  - {3,5}"
            , a
            , b
            , (a - b < 0) ? (b - a < eps) : (a - b < eps)
            , ((a - b < 0) ? (b - a < eps) == true : (a - b < eps) == true) ? "OK!" : "Not OK :/");

        a = -0.0000007d; //true
        b = 0.00000007d;
        Console.WriteLine("{0,12} == {1,12} is {2,12}  - {3,5}"
            , a
            , b
            , (a - b < 0) ? (b - a < eps) : (a - b < eps)
            , ((a - b < 0) ? (b - a < eps) == true : (a - b < eps) == true) ? "OK!" : "Not OK :/");

        a = -4.999999d; //false
        b = -4.999998d;
        Console.WriteLine("{0,12} == {1,12} is {2,12}  - {3,5}"
            , a
            , b
            , (a - b < 0) ? (b - a < eps) : (a - b < eps)
            , ((a - b < 0) ? (b - a < eps) == false : (a - b < eps) == false) ? "OK!" : "Not OK :/");
        a = 4.999999d; //false
        b = 4.999998d;
        Console.WriteLine("{0,12} == {1,12} is {2,12}  - {3,5}"
            , a
            , b
            , (a - b < 0) ? (b - a < eps) : (a - b < eps)
            , ((a - b < 0) ? (b - a < eps) == false : (a - b < eps) == false) ? "OK!" : "Not OK :/");

    }
}

