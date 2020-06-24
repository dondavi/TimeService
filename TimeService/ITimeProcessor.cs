using System;
using System.Collections.Generic;
using System.Text;

namespace TimeService
{
    public interface ITimeProcessor
    {
            DateTime CurrentTimeUTC();
    }
}
