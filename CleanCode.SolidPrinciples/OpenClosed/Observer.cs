using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    public class Observer
    {
        private EnvironmentCleaner cleaner = new EnvironmentCleaner();

        public bool Observe(ObservationPlace place)
        {
            Console.WriteLine(place.Type.Sounds);
            string environment = cleaner.cleanEnvironment(place);

            return cleaner.isEnvironmentExist(environment);
        }
    }
}
