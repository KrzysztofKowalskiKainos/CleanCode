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
            
            tR.DoRoundHouseKick();

            Console.WriteLine("TexasRanger utworzony");
            

            //Single Responsibility



            //Dependancy Inversion !

            // Copying machine dostaje drukarkę (Printer) jaką tam sobie zażyczymy - wygodne !
            // Zmienna w  typie interfejsu Ipreinter

            IPrinter printer = new Printer();
            //IPrinter printer = new RichPrinter();
            CopyingMachine copy = new CopyingMachine(printer);
            copy.Copy("maciek", 3);



            Console.ReadLine();

        }
    }
}
