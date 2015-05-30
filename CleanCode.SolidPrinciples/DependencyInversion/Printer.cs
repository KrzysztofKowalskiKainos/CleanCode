using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public class Printer : IPrinter
    {
        public void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }
       
    }
}