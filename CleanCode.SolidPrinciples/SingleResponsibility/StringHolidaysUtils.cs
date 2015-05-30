using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
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
    class StringHolidaysUtils
    {
        
        private string[] _references;

        public string HolidayName { get; private set; }

        public StringHolidaysUtils(string holidayName, params string[] references)
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
