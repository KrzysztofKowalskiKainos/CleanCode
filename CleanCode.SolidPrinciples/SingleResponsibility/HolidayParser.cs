using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    class HolidayParser
    {
        private string[] _references;
        private Holiday _holiday;
        public HolidayParser(Holiday holiday)
        {
            this._holiday = holiday;
        }
        public int CountReferences(string inputString)
        {
            return _references.Sum(r => Regex.Matches(inputString.ToLower(), Regex.Escape(r.ToLower())).Count);
        }

  
    }
}
