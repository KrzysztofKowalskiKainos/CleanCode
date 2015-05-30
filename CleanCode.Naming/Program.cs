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
            var rectangle = new RectangleClass(10, 20);

            Console.WriteLine(rectangle.GetField());

            Thread.Sleep(10);
            Console.WriteLine(rectangle.GetExistanceDuration(false));

            Thread.Sleep(1002);
            Console.WriteLine(rectangle.GetExistanceDuration(true));
        }
    }
}
