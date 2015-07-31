using System;

public class ExamResult
{
    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentException("grade is null or <0");
        }

        if (minGrade < 0)
        {
            throw new ArgumentException("minGrade is null or <0");
        }

        if (maxGrade < 0)
        {
            throw new ArgumentException("maxGrade is null or <0");
        }

        if (maxGrade <= minGrade)
        {
            throw new ArgumentException("maxGrade must be bigger then minGrade");
        }

        if (comments == null || comments == string.Empty)
        {
            throw new ArgumentException("comments is null or empty");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }

    public int Grade { get; private set; }

    public int MinGrade { get; private set; }

    public int MaxGrade { get; private set; }

    public string Comments { get; private set; }
}
