﻿namespace Mines
{
    using System;

    public class HighScore
    {
        private string name;
        private int points;

        public HighScore()
        {
        }

        public HighScore(string name, int points)
        {
            this.name = name;
            this.points = points;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Points
        {
            get { return this.points; }
            set { this.points = value; }
        }
    }
}