using System;

public class SimpleMathExam : Exam
{
    public SimpleMathExam(int problemsSolved)
    {
        if (problemsSolved < 0 || problemsSolved > 2)
        {
            throw new ArgumentException("problemsSolved must be between 0 and 2");
        }

        this.ProblemsSolved = problemsSolved;
    }

    public int ProblemsSolved { get; private set; }

    public override ExamResult Check()
    {
        switch (this.ProblemsSolved)
        {
            case 0:
                return new ExamResult(2, 2, 6, "Bad result: nothing done.");
            case 1:
                return new ExamResult(4, 2, 6, "Average result: one task done.");
            case 2:
                return new ExamResult(6, 2, 6, "Best result: both tasks done.");
            default:
                throw new Exception("Invalid number of problems solved!");
        }
    }
}
