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
        public PlaceType Type { get; internal set; }

        public string GetSound()
        {
            switch (Type)
            {
                case PlaceType.Forest:
                    return "<Forest Sounds>";
                case PlaceType.Ocean:
                    return "bul bul bul";
                default:
                    throw new InvalidOperationException("Unknown place");
            }
        }
        public string[] GetIgnoredSightings()
        {
            switch (Type)
            {
                case PlaceType.Forest:
                    return new[] { "|", "@" };

                case PlaceType.Ocean:
                    return new[] { "~" };
                default:
                    throw new InvalidOperationException("Unknown place");
            }
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