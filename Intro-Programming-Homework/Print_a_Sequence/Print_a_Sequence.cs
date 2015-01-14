using System;

//Problem 9. Print a Sequence
//
//Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...

class Print_a_Sequence
{
    static void Main()
    {
        int members = 10; //positive number >=1 !!
        int firstmember = 2;
        int member = firstmember;

        for (int i = 1; i <= members; i++)
        {
            System.Console.Write(member);
            if (member < 0) member = member * (-1); //Ако е отрицателно, го правим полужително, за да увеличим с единица.
            member++;
            if (member % 2 != 0) member = member * (-1); // Ако е нечетно, го правим отрицателно.
            if (i != members) System.Console.Write(", "); //Добавя запетайки, ако не е последният елемент.
        }
    }
}