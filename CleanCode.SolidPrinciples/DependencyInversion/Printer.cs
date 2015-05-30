using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public class Printer : IPrinters
    {
        public void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }
    }
}