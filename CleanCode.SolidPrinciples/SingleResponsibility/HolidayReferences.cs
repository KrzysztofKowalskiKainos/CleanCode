using System.Linq;
using System.Text.RegularExpressions;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class HolidayReferences
    {
        private readonly string[] _references;

        public HolidayReferences(params string[] references)
        {
            _references = references;
        }

        public int CountReferences(string inputString)
        {
            return _references.Sum(r => Regex.Matches(inputString.ToLower(), Regex.Escape(r.ToLower())).Count);
        }
    }
}
