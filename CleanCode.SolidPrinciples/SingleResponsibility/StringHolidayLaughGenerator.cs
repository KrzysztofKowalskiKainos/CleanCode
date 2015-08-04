using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class StringHolidayLaughGenerator
    {

        private String laugh;

        public StringHolidayLaughGenerator(string laugh)
        {
            this.laugh = laugh;
        }

        public string GenerateLaugh(int nrOfTimes)
        {
            return string.Concat(Enumerable.Repeat(laugh, nrOfTimes));
        }
    }
}
