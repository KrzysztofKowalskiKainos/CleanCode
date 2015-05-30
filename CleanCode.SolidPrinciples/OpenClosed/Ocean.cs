using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    class Ocean:Place
    {

        public Ocean()
        {
            sound = "bul bul bul";
            ignoredSightings = new[] { "~" };
        }

       
    }
}
