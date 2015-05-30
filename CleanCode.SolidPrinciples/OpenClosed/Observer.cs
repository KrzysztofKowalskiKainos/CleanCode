using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    public class Observer
    {
        private EnvironmentCleaner remover = new EnvironmentCleaner();

        public bool Observe(ObservationPlace place)
        {
            return remover.cleanEnvironment(place);
        }
    }
}
