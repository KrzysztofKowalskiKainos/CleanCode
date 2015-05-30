using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    class PrinterCopyingMachine : ICanCopy, ICanPrint
    {
        public void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }

        public void Copy(string textToCopy, int nrOfCopies)
        {
            for (int i = 0; i < nrOfCopies; i++)
            {
                Print(textToCopy);
            }
        }
    }
}