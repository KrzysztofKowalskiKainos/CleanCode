using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public class Printer
    {
        internal void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }
    }
}