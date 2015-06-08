using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    public class Observer
    {
        public bool Observe(ObservationPlace place, string[] ignoredSightings)
        {
            return place.Type.countEnvironmentSound(ignoredSightings) > 0;
        }
    }
}
