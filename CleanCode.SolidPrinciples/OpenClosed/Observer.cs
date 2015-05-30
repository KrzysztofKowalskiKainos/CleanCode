using System;

namespace CleanCode.SolidPrinciples
{
    public class Observer
    {
        public bool Observe(ObservationPlace place)
        {
            Console.WriteLine(place.Sound());
            return place.Observe();
        }
    }
}
