using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    public class Observer
    {
        public bool Observe(ObservationPlace place)
        {
            switch (place.Type)
            {
                case PlaceType.Forest:
                case PlaceType.Ocean:
                    Console.WriteLine(place.Sound);
                    return place.HasSightings();
                default:
                    throw new InvalidOperationException("Unknown place");
            }
        }
    }
}
