using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public interface IPrinter
    {
        void Print();
    }

    public class Printer : IPrinter
    {
        internal void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }
    }
}