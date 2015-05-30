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
            string[] ignoredSightings;
            string result;

            result = place.Environment;
            foreach (var ignored in ignoredSightings)
                result = result.Replace(ignored, string.Empty);

            return result.Length > 0;

            //switch (place.Type)
            //{
            //    case PlaceType.Forest:
            //        ignoredSightings = new[] { "|", "@" };
            //        Console.WriteLine("<Forest Sounds>");

            //        result = place.Environment;
            //        foreach (var ignored in ignoredSightings)
            //            result = result.Replace(ignored, string.Empty);

            //        return result.Length > 0;
            //    case PlaceType.Ocean:
            //        ignoredSightings = new[] { "~" };
            //        Console.WriteLine("bul bul bul");

            //        result = place.Environment;
            //        foreach (var ignored in ignoredSightings)
            //            result = result.Replace(ignored, string.Empty);

            //        return result.Length > 0;
            //    default:
            //        throw new InvalidOperationException("Unknown place");
            //}
        }
    }
}
