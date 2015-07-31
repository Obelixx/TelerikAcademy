using System;
using System.Collections.Generic;
using System.Text;

public class ExceptionsHomework
{
    public static void Main()
    {
        var substr = StaticMethods.Subsequence("Hello!".ToCharArray(), 2, 3);
        Console.WriteLine(substr);

        var subarr = StaticMethods.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 2);
        Console.WriteLine(string.Join(" ", subarr));

        var allarr = StaticMethods.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 4);
        Console.WriteLine(string.Join(" ", allarr));

        var emptyarr = StaticMethods.Subsequence(new int[] { -1, 3, 2, 1 }, 0, 0);
        Console.WriteLine(string.Join(" ", emptyarr));

        try
        {
            Console.WriteLine(StaticMethods.ExtractEnding("I love C#", 2));
            Console.WriteLine(StaticMethods.ExtractEnding("Nakov", 4));
            Console.WriteLine(StaticMethods.ExtractEnding("beer", 4));
            Console.WriteLine(StaticMethods.ExtractEnding("Hi", 100));
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }

        int[] num = new int[] { 23, 33 };
        for (int i = 0; i < num.Length; i++)
        {
            if (StaticMethods.CheckPrime(num[i]))
            {
                Console.WriteLine(num[i] + " is prime.");
                continue;
            }

            Console.WriteLine(num[i] + " is not prime");
        }

        List<Exam> peterExams = new List<Exam>()
        {
            new SimpleMathExam(2),
            new CSharpExam(55),
            new CSharpExam(100),
            new SimpleMathExam(1),
            new CSharpExam(0),
        };
        Student peter = new Student("Peter", "Petrov", peterExams);
        Console.WriteLine("Average results = {0:p0}", peter.AverageExamResultsInPercents);
    }
}
