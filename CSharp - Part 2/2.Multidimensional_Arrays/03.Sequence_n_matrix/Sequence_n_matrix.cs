using System;

//Problem 3. Sequence n matrix

//    We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour elements located on the same line, column or diagonal.
//    Write a program that finds the longest sequence of equal strings in the matrix.

//Example:
//matrix 	result 		matrix 	result
//ha 	fifi 	ho 	hi
//fo 	ha 	hi 	xx
//xxx 	ho 	ha 	xx
//    ha, ha, ha 		
//s 	qq 	s
//pp 	pp 	s
//pp 	qq 	s
//    s, s, s

class Sequence_n_matrix
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

    public static void Print_array(string[,] a,int padding)
    {
        //int padding = (a.GetLength(0) * a.GetLength(1)).ToString().Length;

        Console.WriteLine();
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j].ToString().PadLeft(padding));
                if (j != a.GetLength(1) - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    public static void Add_result_to_array(string[,] arr, int bestLenght, string bestDir, int bestI, int bestJ)
    {
        int padding = (arr.GetLength(0) * arr.GetLength(1)).ToString().Length;

        for (int i = 0; i < bestLenght; i++)
        {
            if (bestDir == "right")
            {
                arr[bestI, bestJ + i] = "[" + arr[bestI, bestJ + i] + "]";

            }
            if (bestDir == "down")
            {
                arr[bestI + i, bestJ] = "[" + arr[bestI + i, bestJ] + "]";
            }
            if (bestDir == "diagonal")
            {
                arr[bestI + i, bestJ + i] = "[" + arr[bestI + i, bestJ + i] + "]";

            }
        }
    }

    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;


        //this:

        //int n = Checked_int_input("Input arrays size(size>0): N=", ">", 0);
        //int m = Checked_int_input("Input arrays size(size>0): M=", ">", 0);
        //string[,] arr = new string[n, m];
        //for (int i = 0; i < arr.GetLength(0); i++)
        //{
        //    for (int j = 0; j < arr.GetLength(1); j++)
        //    {
        //        Console.WriteLine("Input [{0},{1}] string", i, j);
        //        arr[i, j] = Console.ReadLine().ToString();
        //    }
        //}

        // or this:

        var arr = new string[,]
                                            {   
                                                {"ha", 	"fifi", "ho", 	"hi"},
                                                {"fo", 	"ha", 	"hi", 	"xx"},
                                                {"xxx", "ho", 	"ha", 	"xx"}
                                                
                                                //{"s", 	"qq", 	"s"},
                                                //{"pp", 	"pp", 	"s"},
                                                //{"pp", 	"qq", 	"s"}



                                            };
        int n = arr.GetLength(0);
        int m = arr.GetLength(1);

        //end or

        int bestLenght = 0;
        int bestI = 0;
        int bestJ = 0;
        string bestDir = "right";

        int longest = 0;

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                int tempCount = 0;
                //right
                for (int k = j; k < arr.GetLength(1); k++)
                {
                    if (arr[i, j] == arr[i, k])
                    {
                        tempCount++;
                    }
                }

                if (bestLenght < tempCount)
                {
                    bestDir = "right";
                    bestLenght = tempCount;
                    bestI = i;
                    bestJ = j;
                }


                //down
                tempCount = 0;
                for (int k = i; k < arr.GetLength(0); k++)
                {
                    if (arr[i, j] == arr[k, j])
                    {
                        tempCount++;
                    }
                }

                if (bestLenght < tempCount)
                {
                    bestDir = "down";
                    bestLenght = tempCount;
                    bestI = i;
                    bestJ = j;
                }

                //diagonal
                tempCount = 0;
                for (int k = i, l = j; k < arr.GetLength(0) && l < arr.GetLength(1); k++, l++)
                {
                    if (arr[i, j] == arr[k, l])
                    {
                        tempCount++;
                    }
                }

                if (bestLenght < tempCount)
                {
                    bestDir = "diagonal";
                    bestLenght = tempCount;
                    bestI = i;
                    bestJ = j;
                }
                if (longest < arr[i, j].Length) longest = arr[i, j].Length;
            }
        }


        // print results:
        Console.WriteLine("Input array:");
        Print_array(arr, longest);

        Console.Write("Best string is: ");

        for (int i = 0; i < bestLenght; i++)
        {
            if (bestDir == "right")
            {
                Console.Write(arr[bestI, bestJ + i]);
                if (i != bestLenght - 1) Console.Write(", ");
            }
            if (bestDir == "down")
            {
                Console.Write(arr[bestI + i, bestJ]);
                if (i != bestLenght - 1) Console.Write(", ");
            }
            if (bestDir == "diagonal")
            {
                Console.Write(arr[bestI + i, bestJ + i]);
                if (i != bestLenght - 1) Console.Write(", ");
            }
        }
        Console.WriteLine();

        Console.WriteLine();
        Console.WriteLine("In array:");
        Add_result_to_array(arr, bestLenght, bestDir, bestI, bestJ);
        Print_array(arr,longest+2);
    }
}

