using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    class CopyingMachine
    {
        private Printer _printer;

        public CopyingMachine(Printer printer)
        {
            _printer = printer;
        }

        public void Copy(Object objectToCopy, int nrOfCopies)
        {
            for(int i=0; i<nrOfCopies; i++)
            {
                _printer.Print(objectToCopy);
            }
        }
    }
}
