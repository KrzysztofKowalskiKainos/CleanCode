using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class StringHoliday
    {
        public string HolidayName { get; private set; }

        public StringLaughterGenerator _laughterGenerator { get; private set; }
        public StringReferenceCounter _referenceCounter { get; private set; }

        public StringHoliday(string holidayName, string laugh, params string[] references)
        {
            HolidayName = holidayName;      

            _laughterGenerator = new StringLaughterGenerator(laugh);
            _referenceCounter = new StringReferenceCounter(references);            
        }
    }
}
