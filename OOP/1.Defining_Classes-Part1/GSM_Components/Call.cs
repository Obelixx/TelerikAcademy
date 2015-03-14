namespace CallNamespace
{
    using System;

    //It should contain date, time, dialled phone number and duration (in seconds).

    public class Call
    {
        private DateTime dateAndTime;
        private string number;
        private TimeSpan duration;


        public DateTime DateAndTime
        {
            get { return dateAndTime; }
        }
        public string Number // we need setter in this prop - then we can change later numbers with names (for ex. from contact book)...
        {
            get { return number; }
            set { number = value; }
        }
        public int DurationSeconds
        {
            get { return (int)duration.TotalSeconds; }
        }
        public TimeSpan Duration
        {
            get { return duration; }
        }


        public Call(string number, int durationInSeconds)
        {
            this.dateAndTime = DateTime.Now;
            this.number = number;
            this.duration = TimeSpan.FromSeconds(durationInSeconds);
        }

        public Call(DateTime time, string number, int durationInSeconds)
        {
            this.dateAndTime = time;
            this.number = number;
            this.duration = TimeSpan.FromSeconds(durationInSeconds);
        }

        public override string ToString()
        {
            return ("Call length: [" 
                + duration.Hours.ToString() + "h " 
                + duration.Minutes.ToString().PadLeft(2) + "m " 
                + duration.Seconds.ToString().PadLeft(2) + "s]" 
                + " @ [" + dateAndTime 
                + "] With: " + number);
        }

    }
}
