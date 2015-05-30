using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class References
    {
        private string[] _sRefs;
        public References(string[] sParams)
        {
            _sRefs = sParams;
        }

        public int CountReferences(string inputString)
        {
            return _sRefs.Sum(r => Regex.Matches(inputString.ToLower(), Regex.Escape(r.ToLower())).Count);
        }
    }
}
