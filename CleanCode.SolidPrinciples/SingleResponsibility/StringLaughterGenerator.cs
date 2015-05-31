using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class StringLaughterGenerator
    {
        private string _laughSound;

        public StringLaughterGenerator(string laugh)
        {
            _laughSound = laugh;
        }

        public string GenerateLaugh(int nrOfTimes)
        {
            return string.Concat(Enumerable.Repeat(_laughSound, nrOfTimes));
        }
    }
}
