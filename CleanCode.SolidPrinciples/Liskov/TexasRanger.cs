using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.Liskov
{
    class TexasRanger : Walker
    {
        public void DoRoundHouseKick()
        {
            Console.WriteLine("Hyiaa!");
        }

    }
}
