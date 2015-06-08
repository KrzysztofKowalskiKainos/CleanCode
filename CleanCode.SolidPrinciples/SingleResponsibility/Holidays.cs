using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class Holidays
    {
        public string HolidayName { get; private set; }

        public Holidays(string holidayName)
        {
            HolidayName = holidayName;
        }

    }

}
