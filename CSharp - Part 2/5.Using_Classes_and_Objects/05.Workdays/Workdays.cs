
//Problem 5. Workdays

//    Write a method that calculates the number of workdays between today and given date, passed as parameter.
//    Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.

namespace _05.Workdays
{
    using System;
    using System.Linq;

    class MyClass_Workdays
    {
        public static bool DateIsInArray(DateTime sourceDate, DateTime[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (sourceDate.Equals(values[i])) return true;
            }
            return false;
        }

        public static int WorkDaysCount(DateTime startDate, DateTime endDate, DateTime[] publicHolidays)//startDate must be befor endDate
        {
            int count = 0;
            string[] weekends = {"Saturday","Sunday"};
            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                bool workDay = true;
                if (weekends.Contains(i.DayOfWeek.ToString()))
                {
                    workDay = false;
                }
                else
                    if (publicHolidays.Contains(i))
                    {
                        workDay = false;
                    }
                if (workDay) count++;
            }
            return (count);
        }

        static void Main()
        {
            //            Накратко, следните дни са официални празници и неработни през 2015 г.:

            //1 януари 2015 – Нова година.
            //2, 3 март – Ден на Освобождението на България от османско робство.
            //10, 11, 12, 13 април – Великден – християнската религия отбелязва Възкресение Христово.
            //1 май – Ден на труда и на международната работническа солидарност.
            //6 май – Гергьовден, Ден на храбростта и Българската армия
            //21 и 22 септември – Ден на независимостта на България
            //24, 25, 26 декември – Коледа
            //31 декември и 1 януари 2016

            DateTime[] publicHolidays2015 = new DateTime[]
            {
                new DateTime(2015, 1, 1),
                new DateTime(2015, 3, 2),
                new DateTime(2015, 3, 3),
                new DateTime(2015, 4, 10),
                new DateTime(2015, 4, 11),
                new DateTime(2015, 4, 12),
                new DateTime(2015, 4, 13),
                new DateTime(2015, 5, 1),
                new DateTime(2015, 5, 6),
                new DateTime(2015, 9, 21),
                new DateTime(2015, 9, 22),
                new DateTime(2015, 12, 24),
                new DateTime(2015, 12, 25),
                new DateTime(2015, 12, 26),
                new DateTime(2015, 12, 31),
            };

            //this:

            //DateTime now = DateTime.Now; 
            //int days = 5; 
            //DateTime today = new DateTime(now.Year, now.Month, now.Day);
            //DateTime daysAfter_today = today.AddDays(days);

            //or this:

            DateTime today = new DateTime(2015, 12, 22);
            DateTime daysAfter_today = new DateTime(2015, 12, 26);

            //end or


            int workDays = WorkDaysCount(today,daysAfter_today,publicHolidays2015);
            string format = "dd.MM.yyyy";
            Console.WriteLine("Workdays from {0} to {1} are: {2}",today.ToString(format),daysAfter_today.ToString(format),workDays);
            

        }
    }
}
