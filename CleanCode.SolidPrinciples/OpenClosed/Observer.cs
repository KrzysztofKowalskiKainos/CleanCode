﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    public class Observer
    {
        public bool Observe(IPlace place)
        {
          
            return place.checkLength();
          
        }
    }
}
