using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCode.SolidPrinciples.OpenClosed;
namespace CleanCode.SolidPrinciples.OpenClosed
{
    class Forest : ObservationPlace
    {
       
        
        public Forest()
        {
            environmentSound = "<Forest Sounds>";
            ignoredSightings = new[] { "|", "@" };
        }
    
    }
}
