using System;

namespace CleanCode.SolidPrinciples
{
    public class Observer
    {
        public bool Observe(ObservationPlace place)
        {
            place.Sound();

            return place.IsSomethingObserved();
        }
    }
}
