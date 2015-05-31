using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CleanCode.SolidPrinciples.SingleResponsibility;

namespace CleanCode.SolidPrinciples
{
    class Holidays
    {
       
        public string holidayName { get; private set; }

        public Holidays(string holidayName, Laugh laugh, References Refs, string inputString, int howManyTimes)
        {
            this.holidayName = holidayName;

        }




    }
}
