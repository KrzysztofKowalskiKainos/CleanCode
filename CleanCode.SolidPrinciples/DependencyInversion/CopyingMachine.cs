using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    class CopyingMachine : IPrinter
    {
        
        public void Print(string Message){

            Console.WriteLine(Message);
        }

        // coś w ten deseń ? 
        public void Copy(string textToCopy, int nrOfCopies)
        {
            for(int i=0; i<nrOfCopies; i++)
            {
                Print(textToCopy);
            }
        }

    }
}
