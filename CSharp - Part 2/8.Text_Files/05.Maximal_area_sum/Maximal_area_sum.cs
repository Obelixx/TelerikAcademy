//Problem 5. Maximal area sum

//    Write a program that reads a text file containing a square matrix of numbers.
//    Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//        The first line in the input file contains the size of matrix N.
//        Each of the next N lines contain N numbers separated by space.
//        The output should be a single number in a separate text file.

//Example:
//input 	output
//4
//2 3 3 4
//0 2 3 4
//3 7 1 2
//4 3 3 2 	17

namespace _05.Maximal_area_sum
{
    using System;
    using System.IO;

    class Maximal_area_sum
    {
        static void Maximal_area_and_sum(string path_from, string path_to)
        {
            StreamReader sr = new StreamReader(path_from);
            int n = int.Parse(sr.ReadLine());
            int[,] matrix = new int[n, n];

            for (int i = 0; i < n; i++)
            {
                string[] line = sr.ReadLine().Split(' ');
                for (int j = 0; j < line.Length; j++)
                {
                    matrix[i, j] = int.Parse(line[j]);
                }
            }

            sr.Close();

            bool[,] bmat = {
                            {true,true},
                            {true,true}
                           };
            int maxSum = int.MinValue;
            for (int i = 0; i <= matrix.GetLength(0) - bmat.GetLength(0); i++)
            {
                for (int j = 0; j <= matrix.GetLength(1) - bmat.GetLength(1); j++)
                {
                    int tempSum = 0;
                    for (int ii = 0; ii < bmat.GetLength(0); ii++)
                    {
                        for (int jj = 0; jj < bmat.GetLength(1); jj++)
                        {
                            if (bmat[ii, jj])
                            {
                                tempSum += matrix[i + ii, j + jj];
                            }
                        }
                    }
                    if (maxSum < tempSum)
                    {
                        maxSum = tempSum;
                    }
                }
            }

            StreamWriter sw = new StreamWriter(path_to);
            sw.WriteLine(maxSum);
            sw.Close();
            Console.WriteLine("File Written!");

        }

        static void Main()
        {
            string path_from = @"..\..\TextFile_from.txt";
            string path_to = @"..\..\TextFile_to.txt";
            Maximal_area_and_sum(path_from, path_to);

        }
    }
}
