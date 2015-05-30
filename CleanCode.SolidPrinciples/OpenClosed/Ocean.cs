using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    class Ocean
    {
        protected string[] GetIgnoredSightings()
        {
            return new[] { "~" };
        }
        public string GetSound()
        {
            return "bul bul bul";
        }
    }
}
