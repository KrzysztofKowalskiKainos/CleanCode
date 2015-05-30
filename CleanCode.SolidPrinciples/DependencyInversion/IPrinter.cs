using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    interface IPrinter
    {
        internal void Print(string textToCopy);
    }
}