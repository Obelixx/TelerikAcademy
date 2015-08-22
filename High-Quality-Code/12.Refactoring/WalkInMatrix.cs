namespace Matrix
{
    using System;
    using System.Text;

    public class WalkInMatrix
    {
        public static void Main(string[] args)
        {
            int n = ConsoleInputN();
            //// int n = 6;
            int[,] matrix = new int[n, n];
            int step = n,
                cellValue = 1,
                row = 0,
                column = 0,
                dX = 1,
                dY = 1;

            FillMatrix(matrix, row, column, ref cellValue, ref dX, ref dY, n);
            FindEmptyCell(matrix, out row, out column);
            if (row != 0 && column != 0)
            {
                dX = 1;
                dY = 1;
                FillMatrix(matrix, row, column, ref cellValue, ref dX, ref dY, n);
            }


            PrintMatrix(matrix);
        }

        private static int ConsoleInputN()
        {
            Console.WriteLine("n = ");
            string input = Console.ReadLine();
            int n = 0;
            while (!int.TryParse(input, out n) || n < 0 || n > 100)
            {
                Console.WriteLine("You haven't entered a correct positive number");
                input = Console.ReadLine();
            }

            return n;
        }

        private static void ChangeDirection(ref int dx, ref int dY)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;
            for (int count = 0; count < 8; count++)
            {
                if (dirX[count] == dx && dirY[count] == dY)
                {
                    cd = count;
                    break;
                }
            }

            if (cd == 7)
            {
                dx = dirX[0];
                dY = dirY[0];
                return;
            }

            dx = dirX[cd + 1];
            dY = dirY[cd + 1];
        }

        private static bool CheckForPossibleWay(int[,] arr, int x, int y)
        {
            int[] dirX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] dirY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < 8; i++)
            {
                if (x + dirX[i] >= arr.GetLength(0) || x + dirX[i] < 0)
                {
                    dirX[i] = 0;
                }

                if (y + dirY[i] >= arr.GetLength(0) || y + dirY[i] < 0)
                {
                    dirY[i] = 0;
                }
            }

            for (int i = 0; i < 8; i++)
            {
                if (arr[x + dirX[i], y + dirY[i]] == 0)
                {
                    return true;
                }
            }

            return false;
        }

        private static void FindEmptyCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
        }

        private static void FillMatrix(int[,] matrix, int startRow, int startColumn, ref int cellValue, ref int dX, ref int dY, int n)
        {
            while (true)
            {
                matrix[startRow, startColumn] = cellValue++;
                if (!CheckForPossibleWay(matrix, startRow, startColumn))
                {
                    break;
                }

                if (startRow + dX >= n || startRow + dX < 0 || startColumn + dY >= n || startColumn + dY < 0 || matrix[startRow + dX, startColumn + dY] != 0)
                {
                    while (startRow + dX >= n || startRow + dX < 0 || startColumn + dY >= n || startColumn + dY < 0 || matrix[startRow + dX, startColumn + dY] != 0)
                    {
                        ChangeDirection(ref dX, ref dY);
                    }
                }

                startRow += dX;
                startColumn += dY;
            }
        }

        private static void PrintMatrix(int[,] matrix)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    var padding = (matrix.GetLength(0) * matrix.GetLength(1)).ToString().Length + 2;
                    sb.Append(string.Format("{0," + padding + "}", matrix[i, j]));
                }

                sb.AppendLine();
            }
            Console.Write(sb.ToString());
        }
    }
}
