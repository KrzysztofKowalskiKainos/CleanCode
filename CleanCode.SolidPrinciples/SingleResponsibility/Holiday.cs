using System.Linq;
using System.Text.RegularExpressions;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class Holiday
    {
        private HolidayLaughterGenerator _holidayLaughterGenerator;
        private HolidayReferences _referenceCounter;

        public string HolidayName { get; private set; }

        public Holiday(string holidayName, string laugh, params string[] references)
        {
            HolidayName = holidayName;

            _holidayLaughterGenerator = new HolidayLaughterGenerator(laugh);
            _referenceCounter = new HolidayReferences(references);
        }

    }
}
