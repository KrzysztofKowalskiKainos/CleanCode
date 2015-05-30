using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public class Printer : IPritnable
    {
        public void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }
    }
}