﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    public class Observer
    {
        public bool Observe(ObservationPlace place)
        {
           
            int result = place.LengthOfIngoredSigns(InputData.ignoredCase[place.Type],InputData.enviromentSounds[place.Type]);
            
            return (result > 0);
            
                   
            
        }
    }
}
