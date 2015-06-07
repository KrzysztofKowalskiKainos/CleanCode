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

            Console.WriteLine(rectangle.CalulateField());

            Thread.Sleep(10000);
            Console.WriteLine(rectangle.GetExistanceDuration(false));

            Thread.Sleep(13402);
            Console.WriteLine(rectangle.GetExistanceDuration(true));

            Console.ReadLine();
        }
    }
}
