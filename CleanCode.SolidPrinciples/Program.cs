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
            ObservationPlace place = new ObservationPlace();
            place.Environment = "|||sadsa";
            place.Type = PlaceType.FOREST;
            Observer observer = new Observer();

            observer.Observe(place);
            Console.ReadLine();

        }
    }
}
