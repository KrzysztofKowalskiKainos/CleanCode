using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class Laugh
    {
        private string _laughSound;
        public Laugh( string laughSound)
        {
            _laughSound = laughSound;
        }
        public string GenerateLaugh(int nbOfTimes)
        {
            return string.Concat(Enumerable.Repeat(_laughSound, nbOfTimes));
        }
    }
}
