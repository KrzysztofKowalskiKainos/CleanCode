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

    class Laugh
    {
        private string _laughSound;

        public Laugh(string laugh)
        {
            _laughSound = laugh;
        }

        public string GenerateLaugh(int nrOfTimes)
        {
            return string.Concat(Enumerable.Repeat(_laughSound, nrOfTimes));
        }
    }

    class References
    {
        private string[] _references;
        public References(params string[] references)
        {
            _references = references;
        }
        public int CountReferences(string inputString)
        {
            return _references.Sum(r => Regex.Matches(inputString.ToLower(), Regex.Escape(r.ToLower())).Count);
        }
    }
}
