using System;

//Problem 4. Print a Deck of 52 Cards

//    Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//        The card faces should start from 2 to A.
//        Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.

//output

//2 of spades, 2 of clubs, 2 of hearts, 2 of diamonds
//3 of spades, 3 of clubs, 3 of hearts, 3 of diamonds
//…  
//K of spades, K of clubs, K of hearts, K of diamonds
//A of spades, A of clubs, A of hearts, A of diamonds

//Note: You may use the suit symbols instead of text.




class Print_a_Deck_of_52_Cards
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        //string[] suits = { "clubs", "diamonds", "hearts", "spades" };  //this line or next line
        string suits ="\u2663\u2666\u2665\u2660";
        string[] restCards = { "J", "Q", "K", "A" };

        for (int i = 2; i <= 14; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                switch (i)
                {
                    case 11:
                    case 12:
                    case 13:
                    case 14:
                        Console.Write("{0} of {1}", restCards[i-11], suits[j]);
                        break;
                    default:
                        Console.Write("{0} of {1}", i, suits[j]);
                        break;
                    
                }

                //whitout switch-case;
                //if (i < 9) Console.Write("{0} of {1}", i, cardSuit = (suits)j);
                //else Console.Write("{0} of {1}", restCards = (cards)i, cardSuit = (suits)j);

                if (j != 3) Console.Write(", ");
            }
            Console.WriteLine();
        }
    } 
}
