namespace _3.Range_Exceptions.Models
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        T rangeStart;
        public T RangeStart
        {
            get { return rangeStart; }
            private set { rangeStart = value; }
        }

        T rangeEnd;
        public T RangeEnd
        {
            get { return rangeEnd; }
            private set { rangeEnd = value; }
        }

        public InvalidRangeException(T rangeStart, T rangeEnd)
            : base()
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        public InvalidRangeException(string message, T rangeStart, T rangeEnd)
            : base(message)
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        public InvalidRangeException(string message, Exception innerEx, T rangeStart, T rangeEnd)
            : base(message, innerEx)
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        public override string Message
        {
            get
            {
                return "Out of range! Value must be betweeen " + rangeStart.ToString() + " and " + RangeEnd.ToString();
            }
        }

    }
}
