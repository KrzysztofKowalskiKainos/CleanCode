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
            Rectangle rectangle = new Rectangle(10, 20);

            Console.WriteLine(rectangle.Field);

            Thread.Sleep(10);
            Console.WriteLine(rectangle.getExistenceDurationInSeconds());

            Thread.Sleep(1002);
            Console.WriteLine(rectangle.getExistenceDurationInMiliseconds());
        }
    }
}
