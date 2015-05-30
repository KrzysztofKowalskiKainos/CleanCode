using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public class Printer
    {
        internal void Print(Object objectToPrint)
        {
            Console.WriteLine(objectToPrint);
        }
    }
}