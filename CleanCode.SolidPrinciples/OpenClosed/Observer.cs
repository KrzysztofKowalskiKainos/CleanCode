using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCode.SolidPrinciples.OpenClosed

namespace CleanCode.SolidPrinciples
{
    public class Observer
    {
        public bool Observe(PlaceType place)
        {


            place.getEnvironement();


            return true;


         
            }
        }
    }
}
