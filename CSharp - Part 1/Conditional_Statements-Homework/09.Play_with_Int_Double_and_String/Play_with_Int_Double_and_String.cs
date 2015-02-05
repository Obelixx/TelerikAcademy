using System;

//Problem 9. Play with Int, Double and String

//    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
//        If the variable is int or double, the program increases it by one.
//        If the variable is a string, the program appends * at the end.
//    Print the result at the console. Use switch statement.

//Example 1:
//program 	user
//Please choose a type: 	
//1 --> int 	
//2 --> double 	
//3 --> string 	3

//Please enter a string: 	hello

//hello* 	

//Example 2:
//program 	user
//Please choose a type: 	
//1 --> int 	
//2 --> double 	2
//3 --> string 	

//Please enter a double: 	1.5

//2.5 	

class Play_with_Int_Double_and_String
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;

        byte type = 0;
        Console.Write("Choose type 1-int,2-double,3-string: ");
        while (!byte.TryParse(Console.ReadLine(), out type) || type < 1 || type > 3) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(type));
        
        switch (type)
        {
            case 1:
                Console.Write("Please enter a int:");
                int newInt;
                while (!int.TryParse(Console.ReadLine(), out newInt)) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(newInt));
                newInt += 1;
                Console.WriteLine(newInt);
                break;
            case 2:
                Console.Write("Please enter a double:");
                double newDouble;
                while (!double.TryParse(Console.ReadLine(), out newDouble)) Console.WriteLine("Input {0} number!", Convert.GetTypeCode(newDouble));
                newDouble += 1;
                Console.WriteLine(newDouble);
                break;
            case 3:
                string newString = string.Empty;
                while (newString == null || newString == string.Empty)
                {
                    Console.Write("Please enter a string: ");
                    newString = Console.ReadLine();
                }
                newString += "*";
                Console.WriteLine(newString);
                break;
        }
    }
}

