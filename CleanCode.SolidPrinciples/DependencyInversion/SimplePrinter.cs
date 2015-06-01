using System;

namespace CleanCode.SolidPrinciples
{
    public class SimplePrinter : Printer
    {
        public void Print(string textToPrint)
        {
            Console.WriteLine(textToPrint);
        }
    }
}