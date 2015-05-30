using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    public interface IPrintable
    {
        void Print(string textToPrint);
    }
    public class Printer:IPrintable
    {
        public void Print(string textToCopy)
        {
            Console.WriteLine(textToCopy);
        }
    }
}