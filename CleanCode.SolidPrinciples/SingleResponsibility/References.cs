using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class References
    {
        private string inputString = null;
        private string[] _references = null;

        public References(string inputString, string[] _references)
        {
            this.inputString = inputString;
            this._references = _references;
        }


        public int CountReferences()
        {
            return _references.Sum(r => Regex.Matches(inputString.ToLower(), Regex.Escape(r.ToLower())).Count);
        }
    }
}
