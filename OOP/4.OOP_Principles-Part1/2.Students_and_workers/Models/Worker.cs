namespace _2.Students_and_workers.Models
{
    using System;

    class Worker : Human
    {
        private decimal weekSalary;
        public decimal WeekSalary
        {
            get { return weekSalary; }
            set { weekSalary = value; }
        }

        private double workHoursPerDay = 8;
        public double WorkHoursPerDay
        {
            get { return workHoursPerDay; }
            set { workHoursPerDay = value; }
        }

        private int workDays = 5;
        public int WorkDays
        {
            get { return workDays; }
            set { workDays = value; }
        }

        public Worker(string firstName, string lastName, decimal weekSalary)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
        }

        public decimal MoneyPerHour()
        {
            return (this.WeekSalary / (decimal)(this.WorkDays * this.WorkHoursPerDay));
        }

        public override string ToString()
        {
            return (FirstName + " " + LastName + "\nMoney/h: " + MoneyPerHour().ToString());
        }

    }
}
