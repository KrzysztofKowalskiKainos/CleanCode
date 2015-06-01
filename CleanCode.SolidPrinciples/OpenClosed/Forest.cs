using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    class Forest:Place
    {
       
       

        public Forest()
        {
            ignoredSightings = new[] { "|", "@" };
            sound = "<Forest Sounds>";
        }

        
    }
}
