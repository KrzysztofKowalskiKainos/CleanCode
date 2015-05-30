using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    public class Observer
    {
        private EnvironmentCleaner _cleaner = new EnvironmentCleaner();

        public bool Observe(ObservationPlace place)
        {
            Console.WriteLine(place.Type.Sounds);
            string environment = _cleaner.cleanEnvironment(place);

            return _cleaner.isEnvironmentExist(environment);
        }
    }
}
