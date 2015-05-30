using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public class Printer : IPrinter
    {
        internal void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }


    }
}