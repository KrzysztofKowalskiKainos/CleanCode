using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    static class LaughGenerator
    {
        public string GenerateLaugh(Holiday holiday, int nrOfTimes)
        {
            return string.Concat(Enumerable.Repeat(holiday.LaughSound, nrOfTimes));
        }
    }
}
