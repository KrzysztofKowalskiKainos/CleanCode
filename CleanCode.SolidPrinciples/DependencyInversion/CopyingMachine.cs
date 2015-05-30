﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public interface ICopyingMachine
    {
        void Copy();
    }

    class CopyingMachine : ICopyingMachine, IPrinter
    {
        //private Printer _printer;

        //public CopyingMachine(Printer printer)
        //{
        //    _printer = printer;
        //}

        public void Copy(string textToCopy, int nrOfCopies)
        {
            for(int i=0; i<nrOfCopies; i++)
            {
                _printer.Print(textToCopy);
            }
        }
    }
}
