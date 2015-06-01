using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public class Printer : IPrintingDevice
    {
        public void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }
    }
}