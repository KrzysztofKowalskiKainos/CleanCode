using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class ReferencesCounter
    {

        public ReferencesCounter()
        {
        }


        public int CountReferences(string inputString, string[] _references)
        {
            return _references.Sum(r => Regex.Matches(inputString.ToLower(), Regex.Escape(r.ToLower())).Count);
        }
    }
}
