using System;

//Problem 3. Check for a Play Card

//    Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A. Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise. Examples:

//character 	Valid card sign?
//5 	yes
//1 	no
//Q 	yes
//q 	no
//P 	no
//10 	yes
//500 	no

class Check_for_a_Play_Card
{
    static void Main()
    {
        string[] cardFaces = new string[13] { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string card = string.Empty;
        while (card == null || card == string.Empty)
        {
            Console.Write("Enter your card sign here: ");
            card = Console.ReadLine();
        }
        bool isValidCard = false;
        for (int i = 0; i < 13; i++)
        {
            if (string.Compare(cardFaces[i], card) == 0)
            {
                isValidCard = true;
                break;
            }
        }

        if (isValidCard) Console.WriteLine("yes");
        else Console.WriteLine("no");
    }
}
