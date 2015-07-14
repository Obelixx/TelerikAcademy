namespace Mines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Mines
    {
        public static void Main(string[] аргументи)
        {
            const int BOARD_ROWS = 5;
            const int BOARD_COLUMNS = 10;
            const int MINES_COUNT = 15;
            const int EMPTY_SPACES = (BOARD_ROWS * BOARD_COLUMNS) - MINES_COUNT;
            string command = string.Empty;
            char[,] field = CreateField(BOARD_ROWS, BOARD_COLUMNS);
            char[,] mines = CreateMines(BOARD_ROWS, BOARD_COLUMNS, MINES_COUNT);
            int counter = 0;
            List<HighScore> highscore = new List<HighScore>(6);
            int row = 0;
            int column = 0;
            bool newGame = true;
            bool gameIsLost = false;
            bool gameIsWon = false;

            do
            {
                if (newGame)
                {
                    Console.WriteLine("Mines! Try to find mine-free spots." +
                    "Command 'top' - to show highscore , 'restart' - to start new game, 'exit' - to exit the game!");
                    ShowBoard(field);
                    newGame = false;
                }

                Console.Write("Input row and column separated by space: ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                    int.TryParse(command[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }

                switch (command)
                {
                    case "top":
                        HighScores(highscore);
                        break;
                    case "restart":
                        field = CreateField(BOARD_ROWS, BOARD_COLUMNS);
                        mines = CreateMines(BOARD_ROWS, BOARD_COLUMNS, MINES_COUNT);
                        ShowBoard(field);
                        gameIsLost = false;
                        newGame = false;
                        break;
                    case "exit":
                        Console.WriteLine("bye-bye!");
                        break;
                    case "turn":
                        if (mines[row, column] != '*')
                        {
                            if (mines[row, column] == '-')
                            {
                                YourTurn(field, mines, row, column);
                                counter++;
                            }

                            if (EMPTY_SPACES == counter)
                            {
                                gameIsWon = true;
                            }
                            else
                            {
                                ShowBoard(field);
                            }
                        }
                        else
                        {
                            gameIsLost = true;
                        }

                        break;
                    default:
                        Console.WriteLine("\nError! No such command. Try: 'top', 'restart', 'turn' or 'exit'. \n");
                        break;
                }

                if (gameIsLost)
                {
                    ShowBoard(mines);
                    Console.Write("\nHrrrrrr! You are dead with {0} points. " + "\nInput your nickname: ", counter);
                    string nickName = Console.ReadLine();
                    HighScore t = new HighScore(nickName, counter);
                    if (highscore.Count < 5)
                    {
                        highscore.Add(t);
                    }
                    else
                    {
                        for (int i = 0; i < highscore.Count; i++)
                        {
                            if (highscore[i].Points < t.Points)
                            {
                                highscore.Insert(i, t);
                                highscore.RemoveAt(highscore.Count - 1);
                                break;
                            }
                        }
                    }

                    highscore.Sort((HighScore r1, HighScore r2) => r2.Name.CompareTo(r1.Name));
                    highscore.Sort((HighScore r1, HighScore r2) => r2.Points.CompareTo(r1.Points));
                    HighScores(highscore);

                    field = CreateField(BOARD_ROWS, BOARD_COLUMNS);
                    mines = CreateMines(BOARD_ROWS, BOARD_COLUMNS, MINES_COUNT);
                    counter = 0;
                    gameIsLost = false;
                    newGame = true;
                }

                if (gameIsWon)
                {
                    Console.WriteLine("\nCONGRATS! You have opend all 35 cells.");
                    ShowBoard(mines);
                    Console.WriteLine("Give me your nickname, for the hall of fame: ");
                    string imeee = Console.ReadLine();
                    HighScore points = new HighScore(imeee, counter);
                    highscore.Add(points);
                    HighScores(highscore);
                    field = CreateField(BOARD_ROWS, BOARD_COLUMNS);
                    mines = CreateMines(BOARD_ROWS, BOARD_COLUMNS, MINES_COUNT);
                    counter = 0;
                    gameIsWon = false;
                    newGame = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee bye-bye.");
            Console.Read();
        }

        private static void HighScores(List<HighScore> points)
        {
            Console.WriteLine("\nPoints:");
            if (points.Count > 0)
            {
                for (int i = 0; i < points.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} points", i + 1, points[i].Name, points[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Empty!\n");
            }
        }

        private static void YourTurn(char[,] board, char[,] mines, int row, int col)
        {
            char around = MinesAround(mines, row, col);
            mines[row, col] = around;
            board[row, col] = around;
        }

        private static void ShowBoard(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < row; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < col; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateField(int boardRows, int boardColumns)
        {
            char[,] board = new char[boardRows, boardColumns];
            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] CreateMines(int boardRows, int boardColumns, int minesCount)
        {
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();
            while (randomNumbers.Count < minesCount)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!randomNumbers.Contains(randomNumber))
                {
                    randomNumbers.Add(randomNumber);
                }
            }

            foreach (int number in randomNumbers)
            {
                int row = number / boardColumns;
                int col = number % boardColumns;
                if (col == 0 && number != 0)
                {
                    row--;
                    col = boardColumns;
                }
                else
                {
                    col++;
                }

                board[row, col - 1] = '*';
            }

            return board;
        }

        private static void CalculateEmplySpaces(char[,] board)
        {
            int row = board.GetLength(0);
            int col = board.GetLength(1);

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    if (board[i, j] != '*')
                    {
                        char count = MinesAround(board, i, j);
                        board[i, j] = count;
                    }
                }
            }
        }

        private static char MinesAround(char[,] board, int row, int col)
        {
            int count = 0;
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);

            if (row - 1 >= 0)
            {
                if (board[row - 1, col] == '*')
                {
                    count++;
                }
            }

            if (row + 1 < rows)
            {
                if (board[row + 1, col] == '*')
                {
                    count++;
                }
            }

            if (col - 1 >= 0)
            {
                if (board[row, col - 1] == '*')
                {
                    count++;
                }
            }

            if (col + 1 < cols)
            {
                if (board[row, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (board[row - 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (board[row - 1, col + 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (board[row + 1, col - 1] == '*')
                {
                    count++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (board[row + 1, col + 1] == '*')
                {
                    count++;
                }
            }

            return char.Parse(count.ToString());
        }
    }
}
