using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    class Forest:IPlace
    {
        string[] ignoredSightings;
        string result;
        public string Environment { get; internal set; }
        public PlaceType Type { get; internal set; }

        public bool checkLength()
        {
            ignoredSightings = new[] { "|", "@" };
            Console.WriteLine("<Forest Sounds>");

            result = Environment;
            foreach (var ignored in ignoredSightings)
                result = result.Replace(ignored, string.Empty);

            return result.Length > 0;
        }
    }
}
