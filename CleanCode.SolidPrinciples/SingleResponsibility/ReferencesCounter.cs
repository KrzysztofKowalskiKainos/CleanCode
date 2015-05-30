using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class ReferencesCounter
    {
        private string _stringToBeCompared;
        private string[] _referencesToBeCompared;


        public ReferencesCounter(string[] references, string inputString)
        {
            _stringToBeCompared = inputString;
            _referencesToBeCompared = references;
        }

        public int CountReferences(string inputString)
        {
            return _referencesToBeCompared.Sum(r => Regex.Matches(inputString.ToLower(), Regex.Escape(r.ToLower())).Count);
        }
    }
}
