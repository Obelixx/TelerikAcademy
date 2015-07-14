namespace _4.RefactorMyCSharpPart1ExamSolutions
{
    using System;
    using System.Numerics;

    // The class name is by the task description!
    public class ConsoleApplication1
    {
        public static void Start()
        {
            int count = 0;
            BigInteger firstProduct = 1;
            BigInteger secondProduct = 1;
            string digit;
            while (true)
            {
                try
                {
                    string inputLine = Console.ReadLine();
                    int test_parse = int.Parse(inputLine);
                    if (inputLine[0] == '-')
                    {
                        inputLine.Remove(0, 1);
                    }

                    digit = inputLine;
                }
                catch (Exception)
                {
                    if (secondProduct != 1)
                    {
                        Console.WriteLine(secondProduct);
                    }
                    else
                    {
                        Console.WriteLine(firstProduct);
                    }

                    return;
                }

                if (count == 10)
                {
                    Console.WriteLine(firstProduct);
                }

                if (count % 2 != 0)
                {
                    // if (digit < 0) digit = -digit;
                    int[] digits = new int[digit.Length];
                    for (int i = 0; i < digit.Length; i++)
                    {
                        digits[i] = int.Parse(digit[i].ToString());
                    }

                    for (int i = 0; i < digit.Length; i++)
                    {
                        if (count <= 10)
                        {
                            if (digits[i] != 0)
                            {
                                firstProduct *= (ulong)digits[i];
                            }
                        }
                        else
                        {
                            if (digits[i] != 0)
                            {
                                secondProduct *= (ulong)digits[i];
                            }
                        }
                    }
                }

                count++;
            }
        }
    }
}
