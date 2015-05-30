using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using CleanCode.SolidPrinciples.SingleResponsibility;

namespace CleanCode.SolidPrinciples
{
    class StringHolidaysUtils
    {
        private string _laughSound;
        int iReferences;
       
        public string HolidayName { get; private set; }

        public StringHolidaysUtils(string holidayName, Laugh laugh, References Refs, string inputString, int howManyTimes)
        {

            _laughSound = laugh.GenerateLaugh(howManyTimes);
            HolidayName = holidayName;
            iReferences = Refs.CountReferences(inputString);
        }




    }
}
