using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    public class EnvironmentCleaner
    {
        public bool cleanEnvironment(ObservationPlace place)
        {
            Console.WriteLine(place.Type.Sounds);
            string environment = place.Environment;
            environment = clean(environment, place.Type.IgnoredSightings);
            return isEnvronmentExist(environment);
        }

        private string clean(string environment, string[] ignoredSightings)
        {
            foreach (var ignored in ignoredSightings)
                environment = environment.Replace(ignored, string.Empty);
            return environment;
        }

        private bool isEnvronmentExist(string environment)
        {
            return environment.Length > 0;
        }
    }
}
