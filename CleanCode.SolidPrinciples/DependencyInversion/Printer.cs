using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public class Printer : IPritnable
    {
        internal void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }
    }
}