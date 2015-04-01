namespace _2.Students_and_workers.Extensions
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students_and_workers.Models;

    static class WorkerExtensions
    {
        public static List<Worker> SortedByMoneyPerHour(this List<Worker> workers)
        {
            return (workers.OrderBy(worker => -worker.MoneyPerHour()).ToList());
        }
    }
}
