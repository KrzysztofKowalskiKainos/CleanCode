using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    public class ObservationPlace
    {
        public string Environment { get; internal set; }

        public string GetSound()
        {
            return "";
        }
        protected string[] GetIgnoredSightings()
        {
            return new string[] {};
        }
        public string GetEnvironment(){
            string result = Environment;
            string[] ignoredSightings = GetIgnoredSightings();
            foreach (var ignored in ignoredSightings)
            {
                result = result.Replace(ignored, string.Empty);
            }
            return result;
        }
    }
}