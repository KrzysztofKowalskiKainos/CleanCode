using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class CopyingMachine
    {
        IPrinter printer;

        public CopyingMachine(IPrinter printer)
        {
            this.printer = printer;
        }


        // coś w ten deseń ? 
        public void Copy(string textToCopy, int nrOfCopies)
        {
            for(int i=0; i<nrOfCopies; i++)
            {
                printer.Print(textToCopy);
            }
        }

    }
}
