
namespace Timer_namespace
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading;
    using System.Threading.Tasks;

    // Todo: Problem 7. Timer
    //Using delegates write a class Timer that can execute certain method at each t seconds.


    public class Timer
    {
        public delegate void ExecuteAtEach();
        System.Timers.Timer timer;

        private ExecuteAtEach functions;

        public Timer(int seconds)
        {
            this.timer = new System.Timers.Timer(seconds * 1000);
        }

        public void Start()
        {
            timer.Start();
            timer.Elapsed += timer_Elapsed;
        }

        private void timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            if (functions != null)
            {
                functions();
            }
        }

        public void Stop()
        {
            timer.Stop();
        }

        public void AddDelegate(ExecuteAtEach d)
        {
            functions += d;
        }

    }
}
