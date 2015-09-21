using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class StringHolidaysLaugh
    {
        //------------------------------------ MEMBERS ---------------------------------------//
        private string laughSound;

        // ----------------------------------- METHODS ---------------------------------------//
                                            //constructors
        StringHolidaysLaugh()
        {
            laughSound = null;
        }
        StringHolidaysLaugh(string laughSound)
        {
            this.laughSound = laughSound;
        }

  
                                            //setters
        public void set_laughSound(string laughSound)
        {
            this.laughSound = laughSound;
        }
                                            //getters
        public string get_laughSound()
        {
            return laughSound;
        }
        
                                            //operations
        public string generateLaugh(int nrOfTimes)
        {
            return string.Concat(Enumerable.Repeat(laughSound, nrOfTimes));
        }

        //destructor
        ~StringHolidaysLaugh()
        {

        }
    }
}
