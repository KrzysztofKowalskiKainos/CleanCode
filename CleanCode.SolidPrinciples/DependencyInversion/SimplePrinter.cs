using System;

namespace CleanCode.SolidPrinciples
{
    public class SimplePrinter : IPrinter
    {
        public void Print(string textToPrint)
        {
            Console.WriteLine(textToPrint);
        }
    }
}