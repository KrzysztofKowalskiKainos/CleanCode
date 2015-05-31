﻿using System;
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
            var rectangle = new Rect(10, 20);

            Console.WriteLine(rectangle.GetFieldValue());

            Thread.Sleep(10);
            Console.WriteLine(rectangle.GetExistanceDurationInMilliSeconds());

            Thread.Sleep(1002);
            Console.WriteLine(rectangle.GetExistanceDurationInSeconds());
        }
    }
}
