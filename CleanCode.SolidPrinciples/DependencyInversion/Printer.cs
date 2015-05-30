using System;

namespace CleanCode.SolidPrinciples
{
    public class Printer : IPrinter
    {
        public void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }


    }
}