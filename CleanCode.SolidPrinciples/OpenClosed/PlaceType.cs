using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    public class PlaceType
    {
        public string placeName;
        public string environment;


        public PlaceType(string env, string name){
            placeName = name;
            environment = env;
        }

        public int countEnvironmentSound(string[] ignoredSightings)
        {
            string result = environment;
            foreach (var ignored in ignoredSightings)
                result = result.Replace(ignored, string.Empty);
            return result.Length;
        }
    }
}
