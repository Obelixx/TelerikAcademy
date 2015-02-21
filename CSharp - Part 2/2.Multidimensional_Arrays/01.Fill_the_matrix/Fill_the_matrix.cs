using System;

//Problem 1. Fill the matrix

//    Write a program that fills and prints a matrix of size (n, n) as shown below:

//Example for n=4:
//a) 	b) 	c) 	d)*
//1 	5 	9 	13
//2 	6 	10 	14
//3 	7 	11 	15
//4 	8 	12 	16

//1 	8 	9 	16
//2 	7 	10 	15
//3 	6 	11 	14
//4 	5 	12 	13

//7 	11 	14 	16
//4 	8 	12 	15
//2 	5 	9 	13
//1 	3 	6 	10

//1 	12 	11 	10
//2 	13 	16 	9
//3 	14 	15 	8
//4 	5 	6 	7

class Fill_the_matrix
{
    public static bool Compare_ints(string op, int x, int y)
    {
        switch (op)
        {
            case "==": return x == y;
            case "!=": return x != y;
            case ">": return x > y;
            case ">=": return x >= y;
            case "<": return x < y;
            case "<=": return x <= y;
            case "NoString": return true;
            case "!NoString": return false;
            default:
                throw (new System.ArgumentException("Bad operator - use only: \"==\" \"!=\" \">\" \">=\" \"<\" \"<=\" "));
        }
    }

    public static int Checked_int_input(string what, string operator_in_string = "NoString", int number = 0)
    {
        int output;


        Console.Write(what);
        while (!int.TryParse(Console.ReadLine(), out output) || !Compare_ints(operator_in_string, output, number))
        {
            Console.WriteLine("Input {0} Number (number{1}{2})!", Convert.GetTypeCode(output), operator_in_string, number);
        }
        return (output);
    }

    public static void Print_array(int[] a)
    {
        int padding = (a.Length.ToString().Length);

        Console.WriteLine();
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i].ToString().PadLeft(padding));
            if (i != a.Length - 1) Console.Write(", ");
            if (i + 1 % 10 == 0) Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void Print_array(int[,] a)
    {
        int padding = (a.GetLength(0) * a.GetLength(1)).ToString().Length;

        Console.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j].ToString().PadLeft(padding));
                Console.Write(", ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void fillA(int[,] a, int startRow, int startCol, int fillStart)
    {
        int row = startRow;
        int col = startCol;
        int fill = fillStart;

        do
        {
            a[row, col] = fill;

            if (row == a.GetLength(1) - 1)
            {
                row = 0;
                col++;
            }
            else
            {
                row++;
            }

            fill++;
        } while (fill <= a.GetLength(0) * a.GetLength(1));
    }

    public static void changePos(ref int row, ref int col, string dir)
    {
        switch (dir)
        {
            case "up":
                row--;
                break;
            case "down":
                row++;
                break;
            case "left":
                col--;
                break;
            case "right":
                col++;
                break;

            case "up_left":
                row--;
                col--;
                break;
            case "down_left":
                row++;
                col--;
                break;
            case "up_right":
                row--;
                col++;
                break;
            case "down_right":
                row++;
                col++;
                break;

            default:
                throw new ArgumentException("Direction", "Valid strings are: \"up\",\"down\",\"left\",\"right\",\"up_left\",\"down_left\",\"up_right\",\"down_right\"");
        }
    }

    public static void fillB(int[,] a, int startRow, int startCol, int fillStart, string DirectionStart = "right")
    {
        int row = startRow;
        int col = startCol;
        int fill = fillStart;
        string dir = DirectionStart; //up,down,left right

        do
        {
            a[row, col] = fill;

            //change direction
            if (fill != fillStart && (row == a.GetLength(0) - 1 || row == 0))
            {
                if (dir == "down" && row == a.GetLength(0) - 1)
                {
                    col++;
                    dir = "up";
                }
                else
                    if (dir == "up" && row == 0)
                    {
                        col++;
                        dir = "down";
                    }
                    else
                    {
                        changePos(ref row, ref col, dir);
                    }
            }
            else
            {
                changePos(ref row, ref col, dir);
            }
            fill++;
        } while (fill <= a.GetLength(0) * a.GetLength(1));
    }

    public static void fillC(int[,] a, int startRow, int startCol, int fillStart, string DirectionStart = "down_right")
    {
        int row = startRow;
        int col = startCol;
        int fill = fillStart;
        string dir = DirectionStart; //up,down,left right

        do
        {
            a[row, col] = fill;


            if (row == a.GetLength(0) - 1 || col == a.GetLength(1) - 1)
            {

                if (col == a.GetLength(1) - 1) //last col
                {
                    col -= (row - 1);
                    row = 0;
                }
                else
                    if (row == a.GetLength(0) - 1) //last row
                    {
                        row -= (col + 1);
                        col = 0;
                    }
            }
            else
            {
                changePos(ref row, ref col, dir);
            }
            fill++;
        } while (fill <= a.GetLength(0) * a.GetLength(1));
    }

    public static void fillD(int[,] a, int startRow, int startCol, int fillStart, string DirectionStart = "down")
    {
        int row = startRow;
        int col = startCol;
        int fill = fillStart;
        string dir = DirectionStart; //up,down,left right

        int count = 1;
        int count_to = a.GetLength(0);
        int times = 1;

        do
        {
            a[row, col] = fill;

            //count 2 times to count_to then reduse count_to (on first column - we count just one time to count_to)
            //after each count - change direction (down->right->up->left->down)
            
            if (col != 0) times = 2;
            if (count == count_to || count == count_to * times)
            {
                if (dir == "down") dir = "right";
                else if (dir == "right") dir = "up";
                else if (dir == "up") dir = "left";
                else if (dir == "left") dir = "down";
                if (count == count_to * times)
                {
                    count_to--;
                    count = 0;
                }
            }
            changePos(ref row, ref col, dir);
            count++;
            fill++;
        } while (fill <= a.GetLength(0) * a.GetLength(1));
    }


    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;


        int arr_size = Checked_int_input("Input arrays size(size>0): N=", ">", 0);
        int[,] matrix = new int[arr_size, arr_size];

        //for (int i = 0; i < array_of_ints.Length; i++)
        //{
        //    array_of_ints[i] = Checked_int_input("Input element [" + i + "] of the array:");
        //}

        fillA(matrix, 0, 0, 1);
        Print_array(matrix);

        fillB(matrix, 0, 0, 1, "down");
        Print_array(matrix);

        fillC(matrix, matrix.GetLength(1)-1, 0, 1, "down_right");
        Print_array(matrix);

        fillD(matrix, 0, 0, 1, "down");
        Print_array(matrix);
    }
}

