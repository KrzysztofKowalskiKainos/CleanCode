using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public class Printer : IPrinterable
    {
        public void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }
    }
}