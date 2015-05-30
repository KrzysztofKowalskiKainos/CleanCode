using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    interface ICanCopy
    {
        void Copy(string textToCopy, int nrOfCopies);
    }
}
