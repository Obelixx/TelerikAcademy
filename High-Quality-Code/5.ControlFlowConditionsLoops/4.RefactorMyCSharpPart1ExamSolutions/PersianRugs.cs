namespace _4.RefactorMyCSharpPart1ExamSolutions
{
    using System;

    public class PersianRugs
    {
        public static void Start()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int sizeA = (a * 2) + 1;

            int[,] matrix = new int[sizeA, sizeA];

            // 1 = " "
            // 2 = \
            // 3 = /
            // 4 = .
            // 5 = X
            // 6 = #
            int i = 0;
            int j = 0;

            for (i = 0; i < (a * 2) + 1; i++)
            {
                for (j = 0; j < (a * 2) + 1; j++)
                {
                    matrix[i, j] = 1;
                }
            }

            // X
            matrix[a, a] = 5;

            int countI = (a * 2) + 1;
            int countJ = sizeA;
            for (j = 0; j < sizeA; j++)
            {
                for (i = j + 1; i < countJ - 1; i++)
                {
                    matrix[i, j] = 6;
                }

                countJ -= 1;
            }

            for (i = 0; i < a; i++)
            {
                matrix[i, i] = 2;
            }

            for (i = a + 1; i < sizeA; i++)
            {
                matrix[i, i] = 2;
            }

            countJ = sizeA - 1;
            for (i = 0; i < sizeA; i++)
            {
                if (i != countJ)
                {
                    matrix[i, countJ] = 3;
                }

                countJ--;
            }

            countI = 1;
            countJ = a;
            for (j = a + 1; j < sizeA; j++)
            {
                for (i = countJ; i < countJ + countI; i++)
                {
                    matrix[i, j] = 6;
                }

                countI += 2;
                countJ -= 1;
            }

            int smallsize = a - b - 1;

            // \  \.../  /
            // #\  \./  /#
            // ##\     /##
            // ###\   /###
            // ####\ /####
            // #####X#####
            // ####/ \####
            // ###/   \###
            // ##/     \##
            // #/  /.\  \#
            // /  /...\  \
            for (i = 0; i < (a * 2) + 1; i++)
            {
                for (j = 0; j < (a * 2) + 1; j++)
                {
                    switch (matrix[i, j])
                    {
                        case 1:
                            Console.Write(" ");
                            break;
                        case 2:
                            Console.Write("\\");
                            break;
                        case 3:
                            Console.Write("/");
                            break;
                        case 4:
                            Console.Write(".");
                            break;
                        case 5:
                            Console.Write("X");
                            break;
                        case 6:
                            Console.Write("#");
                            break;
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
