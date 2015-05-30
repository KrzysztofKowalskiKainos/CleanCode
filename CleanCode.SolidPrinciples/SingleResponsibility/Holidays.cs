using System.Linq;
using System.Text.RegularExpressions;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class Holidays
    {
        private readonly string[] _references;

        public string HolidayName { get; private set; }

        public Holidays(string holidayName, params string[] references)
        {
            HolidayName = holidayName;
            _references = references;
        }

        public int CountReferences(string inputString)
        {
            return _references.Sum(r => Regex.Matches(inputString.ToLower(), Regex.Escape(r.ToLower())).Count);
        }
    }
}
