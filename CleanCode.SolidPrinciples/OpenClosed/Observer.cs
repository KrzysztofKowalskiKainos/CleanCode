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
            string result;

            try
            {
                result = place.environment;

                foreach (var ignored in place.type.GetIgnoredSightings())
                {
                    result = result.Replace(ignored, string.Empty);
                }

                return result.Length > 0;
            }
            catch (Exception)
            {
                throw new InvalidOperationException("Unknown place");
            }
        }
    }
}
