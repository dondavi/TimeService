using System;
using System.Collections.Generic;
using System.Text;

namespace TimeService
{
    public class TimeProcessor : ITimeProcessor
    {
        public DateTime CurrentTimeUTC()
        {
            return DateTime.UtcNow;
        }
    }
}
