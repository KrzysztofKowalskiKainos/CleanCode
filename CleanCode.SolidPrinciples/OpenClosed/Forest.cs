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
    }
}
