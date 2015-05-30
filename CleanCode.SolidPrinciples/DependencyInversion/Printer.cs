using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public class Printer : IPrin
    {
        internal void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }
    }
}