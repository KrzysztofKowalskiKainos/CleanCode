using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
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
