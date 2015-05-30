using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class RichPrinter : IPrinter
    {
        public void Print(string message)
        {
            Console.WriteLine("!!!" + message);
        }
    }
}
