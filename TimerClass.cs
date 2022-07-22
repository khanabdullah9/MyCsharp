using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace csharp
{
    internal class TimerClass
    {
        private static System.Timers.Timer timer;
        public static void Run() 
        {
            timer = new System.Timers.Timer(2000);
            timer.Elapsed += OnTimedEvent;
            timer.AutoReset = true;
            timer.Enabled = true;
        }

        public static void OnTimedEvent(Object source, ElapsedEventArgs e)
        {
            Console.WriteLine($"The Elapsed event was raised at {e.SignalTime}");
        }
    }
}
