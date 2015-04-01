namespace _3.Range_Exceptions
{
    using System;
    using _3.Range_Exceptions.Models;

    class TestProgram
    {
        static void Main()
        {
            const int start = 0;
            const int end = 100;
            DateTime startDate = new DateTime(1980, 1, 1);
            DateTime endDate = new DateTime(2013, 12, 31);

            ApplicationException error = new InvalidRangeException<int>("Out of Range!", start,end);
            ApplicationException errorDate = new InvalidRangeException<DateTime>("Out of Range!", startDate, endDate);

            //throw error;
            throw errorDate;

        }
    }
}
