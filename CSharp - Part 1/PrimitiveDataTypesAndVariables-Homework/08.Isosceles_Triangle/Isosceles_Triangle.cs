using System;

//Problem 8. Isosceles Triangle

//    Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:

//   ©

//  © ©

// ©   ©

//© © © ©

//Note: The © symbol may be displayed incorrectly at the console so you may need to change the console character encoding to UTF-8 and assign a Unicode-friendly font in the console.

//Note: Under old versions of Windows the © symbol may still be displayed incorrectly, regardless of how much effort you put to fix it.

class Isosceles_Triangle
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.Unicode;
        byte size = 4; // Size must be bigger then 0 !!! Max is coresponding to the half of console width. (default is 80 - so use 40 as Maximum)
        size *= 2;
        size -= 1;
        byte sizeInMatrix = (byte)(size - 1);
        byte[,] matrix = new byte[size, size];


        int i = 0;
        int j = 0;

        while (i <= sizeInMatrix && j <= sizeInMatrix) //Do you truly believe, all is set ot 0? I want to be sure, becouse i'll drow them!
        {
            matrix[i, j] = 0;
            j++;
            if (j > sizeInMatrix)
            {   
                j = 0;
                i++;
            }
        }

        //bottom
        i = sizeInMatrix; // row
        j = 0; // column
        while (j <= sizeInMatrix) 
        {
            matrix[i, j] = 1;
            j += 2;
        }

        //right
        j -= 2;
        while (i >= 0 && j >= sizeInMatrix / 2) 
        {
            matrix[i, j] = 1;
            i -= 2;
            j--;
        }

        //left
        i += 2;
        j++;
        while (i <= sizeInMatrix && j >= 0)
        {
            matrix[i, j] = 1;
            i += 2;
            j--;
        }

        //Print them all
        i = 0;
        j = 0;
        while (i <= sizeInMatrix && j <= sizeInMatrix) 
        {
            Console.Write(matrix[i, j] == 0 ? " " : "\u00a9");
            j++;
            if (j > sizeInMatrix)
            {
                Console.WriteLine();
                j = 0;
                i++;
            }
        }

    }
}

