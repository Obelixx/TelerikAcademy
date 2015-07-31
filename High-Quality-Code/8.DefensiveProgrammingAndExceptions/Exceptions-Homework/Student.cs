using System;
using System.Collections.Generic;
using System.Linq;

public class Student
{
    public Student(string firstName, string lastName, IList<Exam> exams = null)
    {
        if (firstName == null || firstName == string.Empty)
        {
            throw new ArgumentException("Invalid first name!");
        }

        if (lastName == null || lastName == string.Empty)
        {
            throw new ArgumentException("Invalid first name!");
        }

        this.FirstName = firstName;
        this.LastName = lastName;
        this.Exams = exams;
    }

    public string FirstName { get; private set; }

    public string LastName { get; private set; }

    public IList<Exam> Exams { get; private set; } // Later we may set the setter to public. Now we don't need it.

    public double AverageExamResultsInPercents
    {
        get
        {
            if (this.Exams == null)
            {
                throw new Exception("Cannot calculate average on missing exams.");
            }

            if (this.Exams.Count == 0)
            {
                // No exams --> return -1;
                return -1;
            }

            double[] examScore = new double[this.Exams.Count];
            IList<ExamResult> examResults = this.CheckExams(this.Exams);
            for (int i = 0; i < examResults.Count; i++)
            {
                examScore[i] =
                    ((double)examResults[i].Grade - examResults[i].MinGrade) /
                    (examResults[i].MaxGrade - examResults[i].MinGrade);
            }

            return examScore.Average();
        }
    }

    private IList<ExamResult> CheckExams(IList<Exam> exams)
    {
        if (exams == null)
        {
            throw new ArgumentNullException("exams is null");
        }

        if (exams.Count == 0)
        {
            // Console.WriteLine("The student has no exams!");
            return null;
        }

        IList<ExamResult> results = new List<ExamResult>();
        for (int i = 0; i < this.Exams.Count; i++)
        {
            results.Add(this.Exams[i].Check());
        }

        return results;
    }
}
