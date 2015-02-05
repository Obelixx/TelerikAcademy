using System;

//Problem 2. Bonus Score

//    Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//        If the score is between 1 and 3, the program multiplies it by 10.
//        If the score is between 4 and 6, the program multiplies it by 100.
//        If the score is between 7 and 9, the program multiplies it by 1000.
//        If the score is 0 or more than 9, the program prints “invalid score”.

//Examples:
//score 	result
//2 	20
//4 	400
//9 	9000
//-1 	invalid score
//10 	invalid score

class Bonus_Score
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        long score = 0;
        Console.Write("Input Score: ");
        while (!long.TryParse(Console.ReadLine(), out score)) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(score));

        switch (score)
        {
            case 1L:
            case 2L:
            case 3L:
                score *= 10;
                break;
            case 4L:
            case 5L:
            case 6L:
                score *= 100;
                break;
            case 7L:
            case 8L:
            case 9L:
                score *= 1000;
                break;
            default:
                score = 0;
                break;
        }
        if (score != 0)
        {
            Console.WriteLine("Score with bonus: {0}", score);
        }
        else
        {
            Console.WriteLine("invalid score");
        }
    }
}
