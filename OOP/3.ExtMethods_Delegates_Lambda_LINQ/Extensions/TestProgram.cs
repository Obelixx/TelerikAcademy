

using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;
using Student_namespace;
using Extensions.Extensions;
using Timer_namespace;

class TestProgram
{
    static void Pouse()
    {
        Console.WriteLine("\nPress any key..");
        Console.ReadKey();
        Console.Clear();
    }

    static void PrintEnum(IEnumerable students)
    {
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    static void Main()
    {
        Console.WriteLine("\n Test: Problem 1. StringBuilder.Substring \n");
        var sb = new StringBuilder();
        sb.AppendLine(@"Problem 1. StringBuilder.Substring");
        Console.WriteLine(sb.Substring(0, 12));
        Console.WriteLine(sb.Substring(1, 12));
        Pouse();


        Console.WriteLine("\nTest: Problem 2. IEnumerable extensions \n");
        List<int> ints = new List<int>();
        ints.Add(1);
        ints.Add(2);
        ints.Add(3);
        ints.Add(4);
        ints.Add(5);
        //sum, product, min, max, average.
        Console.WriteLine("Sum: " + ints.SumOfList());
        Console.WriteLine("Product: " + ints.ProductOfList());
        Console.WriteLine("Min: " + ints.MinOfList());
        Console.WriteLine("Max: " + ints.MaxOfList());
        Console.WriteLine("Average: " + ints.AverageOfList());
        Pouse();


        Console.WriteLine("\nTest: Problem 3. First before last \n");
        var students = Student.StudentsSample().ToArray();
        students = students.FirstBeforLast();
        PrintEnum(students);
        Pouse();


        Console.WriteLine("\nProblem 4. Age range \n");
        students = Student.StudentsSample().ToArray();
        students = students.Between18and24().ToArray();
        PrintEnum(students);
        Pouse();


        Console.WriteLine("\nTest: Problem 5. Order students \n");
        students = Student.StudentsSample().ToArray();
        students = students.Between18and24().ToArray();
        PrintEnum(students);
        Pouse();


        Console.WriteLine("\nTest: Problem 6. Divisible by 7 and 3 \n");
        ints.Clear();
        ints = new List<int> { 1, 2, 21, 28, 42, 60, 70, 80, 90 };
        DevisibleBy7And3_Lambda(ints.ToArray());
        Pouse();


        Console.WriteLine("\nTest: Problem 7. Timer \n");
        Timer timer = new Timer(1);
        Timer.ExecuteAtEach d = delegate() 
        { 
            Console.WriteLine("Tick every 1sec."); 
        };
        timer.AddDelegate(d);
        timer.Start();
        System.Threading.Thread.Sleep(5000);
        timer.Stop();
        Pouse();


        //Select only the students that are from group number 2.
        //Use LINQ query. Order the students by FirstName.
        Console.WriteLine("\nTest: Problem 9. Student groups \n");
        Console.WriteLine("Group2: ");
        students = Student.StudentsSample().ToArray();
        students = Student.SelectFromGroup2(students.ToList()).ToArray();
        PrintEnum(students);
        Console.WriteLine("Orderd by FirstName: ");
        students = Student.OrderByFirstName(students.ToList()).ToArray();
        PrintEnum(students);
        Pouse();

        //Furstly i done it with extension method with linq query, so i'll not do it again..
        Console.WriteLine("\nTest: Problem 10. Student groups extensions \n");
        Console.WriteLine("Group2: ");
        students = Student.StudentsSample().ToArray();
        students = Student.SelectFromGroup2(students.ToList()).ToArray();
        PrintEnum(students);
        Console.WriteLine("Orderd by FirstName: ");
        students = Student.OrderByFirstName(students.ToList()).ToArray();
        PrintEnum(students);
        Pouse();


        Console.WriteLine("\nTest: No time left ti create the rest of the tests, but methods are there.. \n");
        

    }


    // Todo: Problem 6. Divisible by 7 and 3
    //Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions. Rewrite the same with LINQ.
    static void DevisibleBy7And3_Lambda(int[] arr)
    {
        foreach (var item in arr.ToList().FindAll(i => i % (7 * 3) == 0 && i != 0))
        {
            Console.WriteLine(item);
        }
    }
    static void DevisibleBy7And3_Linq(int[] arr)
    {
        foreach (var item in
            from i in arr
            where i / (7 * 3) == 0
            select i)
        {
            Console.WriteLine(item);
        }
    }

    // Todo: Problem 17. Longest string
    //Write a program to return the string with maximum length from an array of strings.
    //Use LINQ.
    static string LongestString(string[] arr)
    {
        int max = arr[0].Length;
        string bestStr = string.Empty;
        foreach (var str in arr)
        {
            if (max < str.Length)
            {
                max = str.Length;
                bestStr = str;
            }
        }
        return bestStr;
    }

    // Todo: Problem 18. Grouped by GroupNumber
    //Create a program that extracts all students grouped by GroupNumber and then prints them to the console.
    //Use LINQ
    static void GroupedByGroupNumber(List<Student> list)
    {
        var grupedStudents = new List<Student>(from st in list
                                               orderby st
                                               select st);
        foreach (var student in grupedStudents)
        {
            Console.WriteLine(student);
        }
    }


}
