using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class StringHolidaysName
    {
        //------------------------------------ MEMBERS ---------------------------------------//
        private string holidayName;

        // ----------------------------------- METHODS ---------------------------------------//
                                            //constructors
        StringHolidaysName()
        {
            holidayName = null;
        }
        StringHolidaysName(string holidayName)
        {
            this.holidayName = holidayName;
        }
                                            //setters
        public void set_holidayName(string holidayName)
        {
            this.holidayName = holidayName;
        }
                                            //getters
        public string get_holidayName()
        {
            return holidayName;
        }

    }
}
