using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class LaughGenerator
    {

        public string GenerateLaugh(int nrOfTimes, string _laughSound)
        {
            return string.Concat(Enumerable.Repeat(_laughSound, nrOfTimes));
        }

    }

    
}
