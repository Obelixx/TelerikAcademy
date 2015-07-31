﻿using System;

public class CSharpExam : Exam
{
    public CSharpExam(int score)
    {
        if (score < 0 || score > 100)
        {
            throw new ArgumentException("Bad score value!");
        }

        this.Score = score;
    }

    public int Score { get; private set; }

    public override ExamResult Check()
    {
        return new ExamResult(this.Score, 0, 100, "Exam results calculated by score.");
    }
}
