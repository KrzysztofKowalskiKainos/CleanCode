﻿using System;
using System.Threading;

namespace CleanCode.Naming
{
    class Program
    {
        static void Main(string[] args)
        {
            var rectangle = new Rectangle(10, 20);

            Console.WriteLine(rectangle.Field());

            Thread.Sleep(10);
            Console.WriteLine(rectangle.ExistenceTimeInMilliseconds());

            Thread.Sleep(1002);
            Console.WriteLine(rectangle.ExistenceTimeInSeconds());
        }
    }
}
