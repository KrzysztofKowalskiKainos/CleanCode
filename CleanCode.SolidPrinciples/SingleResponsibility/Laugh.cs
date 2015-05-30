using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class Laugh
    {
        
        private String _laughSound;

        public Laugh(string laughSound)
        {
            _laughSound = laughSound;
        }

        public string GenerateLaughByNrOfTimes(int nrOfTimes)
        {
            return string.Concat(Enumerable.Repeat(_laughSound, nrOfTimes));
        }
    }
}
