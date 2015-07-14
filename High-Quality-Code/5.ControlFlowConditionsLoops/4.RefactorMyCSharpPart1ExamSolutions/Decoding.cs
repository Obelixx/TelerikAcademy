namespace _4.RefactorMyCSharpPart1ExamSolutions
{
    using System;

    public class Decoding
    {
        public static void Start()
        {
            // Console.OutputEncoding = System.Text.Encoding.UTF8;
            // System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            int salt = int.Parse(Console.ReadLine());
            string inputText = Console.ReadLine();
            double[] arrayText = new double[inputText.Length - 1];

            for (int i = 0; i < inputText.Length - 1; i++)
            {
                if ((inputText[i] >= (char)65 && inputText[i] <= (char)90) || (inputText[i] >= (char)97 && inputText[i] <= (char)122))
                {
                    arrayText[i] += (inputText[i] * (double)salt) + 1000;
                }
                else
                    if (inputText[i] >= (char)48 && inputText[i] <= (char)57)
                    {
                        arrayText[i] = inputText[i] + salt + 500;
                    }
                    else
                    {
                        arrayText[i] = inputText[i] - (double)salt;
                    }
            }

            for (int i = 0; i < arrayText.Length; i++)
            {
                if (i % 2 == 0)
                {
                    double tempDecimal = arrayText[i] / (double)100;
                    Console.WriteLine("{0:0.00}", tempDecimal);
                }
                else
                {
                    Console.WriteLine((arrayText[i] * 100).ToString("0"));
                }
            }
        }
    }
}