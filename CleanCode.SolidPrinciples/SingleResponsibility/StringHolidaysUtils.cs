using CleanCode.SolidPrinciples.SingleResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class StringHolidaysUtils
    {
        private string _laughSound;
        private string[] _references;

        public string HolidayName { get; private set; }

        public StringHolidaysUtils(string holidayName, string laugh, params string[] references)
        {
            _laughSound = laugh;
            HolidayName = holidayName;
            _references = references;
        }

        public string GenerateLaugh(int nrOfTimes)
        {
            Laugh laugh = new Laugh(nrOfTimes, _laughSound);

            return laugh.GenerateLaugh();
        }

        public int CountReferences(string inputString)
        {
            References reference = new References(inputString, _references);

            return reference.CountReferences();
            
        }
    }
}
