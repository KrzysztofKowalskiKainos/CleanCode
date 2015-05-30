using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class Holiday
    {
        public string HolidayName { get; private set; }
        public string LaughSound { get; private set; }
        public string[] References { get; private set; }

        public Holiday(string holidayName, string laughSound, params string[] references)
        {
            HolidayName = holidayName;
            this.LaughSound = laughSound; 
            this.References = references;
        }
  
    }






}
