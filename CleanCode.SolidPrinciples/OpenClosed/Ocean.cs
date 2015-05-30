using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    public class Ocean :ObservationPlace
    {
        public Ocean()
        {
            this.Type = PlaceType.Ocean;
            this.IgnoredSightings = new[] { "~" };
            this.Message = "bul bul bul";
        }
    }
}
