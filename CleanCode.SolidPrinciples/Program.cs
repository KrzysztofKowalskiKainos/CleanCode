using CleanCode.SolidPrinciples.Liskov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            //Liskov

            TexasRanger tR = new TexasRanger();
            tR.Walk();
            tR.Run();
            tR.DoRoundHouseKick();

            Console.WriteLine("TexasRanger utworzony");


            //Single Responsibility




        }
    }
}
