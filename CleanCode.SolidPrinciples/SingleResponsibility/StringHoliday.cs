using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class StringHoliday
    {
        public string holidayName { get; private set; }

        public StringLaughterGenerator laughterGenerator { get; private set; }
        public StringReferenceCounter referenceCounter { get; private set; }

        public StringHoliday(string holidayName, string laugh, params string[] references)
        {
            this.holidayName = holidayName;      

            laughterGenerator = new StringLaughterGenerator(laugh);
            referenceCounter = new StringReferenceCounter(references);            
        }
    }
}
