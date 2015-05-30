using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.DependencyInversion
{

    class CopyingMachine
    {
        private IPrintable _printer;

        public CopyingMachine(IPrintable printer)
        {
            _printer = printer;
        }

        public void Copy(string textToCopy, int nrOfCopies)
        {
            for(int i=0; i<nrOfCopies; i++)
            {
                _printer.Print(textToCopy);
            }
        }
    }
}
