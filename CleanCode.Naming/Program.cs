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
            var rectangle = new Rectangle(10, 20);

            // calculate area of rectangle
            Console.WriteLine(rectangle.area());

            Thread.Sleep(10);
            Console.WriteLine(rectangle.durationOfExistence(TimeUnit.Miliseconds));

            Thread.Sleep(1002);
            Console.WriteLine(rectangle.durationOfExistence(TimeUnit.Seconds));

        }
    }
}
