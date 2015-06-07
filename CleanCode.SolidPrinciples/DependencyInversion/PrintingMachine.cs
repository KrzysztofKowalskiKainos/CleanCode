using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    class PrintingMachine
    {
        private IPrinter _printer;

        public PrintingMachine(IPrinter printer)
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
