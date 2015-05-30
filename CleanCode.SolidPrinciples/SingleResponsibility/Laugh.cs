using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class Laugh
    {
        private int _nbOfTimes;
        private string _laughSound;
        public Laugh(int nrOfTimes, string laughSound)
        {
            _nbOfTimes = nrOfTimes;
            _laughSound = laughSound;
        }
        public string GenerateLaugh()
        {
            return string.Concat(Enumerable.Repeat(_laughSound, _nbOfTimes));
        }
    }
}
