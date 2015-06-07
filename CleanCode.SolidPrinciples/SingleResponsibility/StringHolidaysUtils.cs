using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class Holiday
    {
        public string HolidayName { get; private set; }

        public Holiday(string holidayName)
        {
            HolidayName = holidayName;
        }
    }
}
