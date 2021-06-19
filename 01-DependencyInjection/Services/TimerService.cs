using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _01_DependencyInjection.Services
{
    public class TimerService : ITimer
    {
        public DateTime Now()
        {
            return DateTime.Now;
        }
    }
}
