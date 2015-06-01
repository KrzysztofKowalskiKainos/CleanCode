using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class LaughGenerator
    {
        public string GenerateLaugh(string laughSound, int nrOfTimes)
        {
            return string.Concat(Enumerable.Repeat(laughSound, nrOfTimes));
        }
    }
}
