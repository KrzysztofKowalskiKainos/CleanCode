using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class Laugh
    {
        private int nrOfTimes = 0;
        private String _laughSound = null;

        public Laugh(int nrOfTimes, string _laughSound)
        {
            this.nrOfTimes = nrOfTimes;
        }


        public string GenerateLaugh()
        {
            return string.Concat(Enumerable.Repeat(_laughSound, nrOfTimes));
        }

    }

    
}
