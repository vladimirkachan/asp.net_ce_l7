using System;

namespace _02_ViewImports.Services
{
    public class TimerService : ITimer
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
