using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanCode.Naming
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangular(10, 20);

            Console.WriteLine(rectangle.GetArea());

            Thread.Sleep(10);
            Console.WriteLine(rectangle.GetDurationOfExistence(TimeUnits.Milliseconds));

            Thread.Sleep(1002);
            Console.WriteLine(rectangle.GetDurationOfExistence(TimeUnits.Seconds));
        }
    }
}
