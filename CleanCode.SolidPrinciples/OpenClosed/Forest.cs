using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    class Forest: ObservationPlace
    {
        protected string[] GetIgnoredSightings()
        {
            return new[] { "|", "@" };
        }
        public string GetSound()
        {
            return "<Forest Sounds>";
        }
    }
}
