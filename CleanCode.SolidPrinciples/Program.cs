using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class Program
    {
        private static void TestOpenClosed()
        {
            Observer o = new Observer();

            ObservationPlace forrest = new Forrest();
            forrest.Environment = "|x";

            Console.WriteLine(o.Observe(forrest) ? "Something found" : "Nothing");
        }

        static void Main(string[] args)
        {
            TestOpenClosed();

            Console.ReadLine();
        }
    }
}
