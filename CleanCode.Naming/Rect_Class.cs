using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class RectClass
    {
        // First side
        private int _aSideLength;

        // Second side
        private int bSideLength;


        private DateTime _date;

        public bool displayType {get; set;}

        public RectClass(int a, int b)
        {
            _aSideLength = a;
            bSideLength = b;

            _date = DateTime.Now;
        }

        public int getField()
        {
            return _aSideLength * bSideLength;
        }
        
        // If duration should be in seconds
        public int durationOfExistence()
        {
            var d = (_date - DateTime.Now);

            if (displayType)
            {
                return (int)d.TotalMilliseconds;
            }
            else
            {
                return (int)d.TotalSeconds;
            }
        }
    }
}
