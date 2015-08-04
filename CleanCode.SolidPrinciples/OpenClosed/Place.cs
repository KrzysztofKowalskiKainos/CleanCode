using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    public class Place
    {
        protected string[] ignoredSightings;
        protected string result;
       
        public string Environment { get; internal set; }
        public PlaceType Type { get; internal set; }
        public string sound;
 
        public bool checkLength()
        {
            Console.WriteLine(sound);



            result = Environment;
            foreach (var ignored in ignoredSightings)
                result = result.Replace(ignored, string.Empty);

            return result.Length > 0;
        }
    }
}
