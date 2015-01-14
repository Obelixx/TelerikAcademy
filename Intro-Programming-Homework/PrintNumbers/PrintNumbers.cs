using System;

//Problem 6. Print Numbers

class PrintNumbers
{
    static void Main()
    {
        // System.Console.WriteLine("1\n101\n1001");
        //
        // Това беше първата идея, но помислих малко и реших, че това е текст.
        //
        // Така ги  принтира като чиала:
        // System.Console.WriteLine(1 + "\n" + 101 + "\n" + 1001);
        //
        // После си поиграх малко:

        for (int i = 1; i <= 100; i *= 10)
        {
            if (i != 1) System.Console.Write(i);
            System.Console.WriteLine(1);
        }
    }
}
