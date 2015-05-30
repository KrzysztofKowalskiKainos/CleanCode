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
            PlaySound(place.GetSound());
            string environment;
            environment = place.GetEnvironment();
            return environment.Length > 0;
        }
        protected void PlaySound(string sound)
        {
            Console.WriteLine(sound);
        }
    }
}
