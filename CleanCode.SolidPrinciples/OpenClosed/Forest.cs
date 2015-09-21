using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    public class Forest: ObservationPlace
    {
        public Forest()
        {
            this.Type = PlaceType.Forest;
            this.IgnoredSightings = new[] { "|", "@" };
            this.Message = "<Forest Sounds>";
        }

        public override bool ObservePlace()
        {
            string result;
            Console.WriteLine(this.Message);

            result = this.Environment;
            foreach (var ignored in this.IgnoredSightings)
                result = result.Replace(ignored, string.Empty);

            return result.Length > 0;
        }
    }
}
