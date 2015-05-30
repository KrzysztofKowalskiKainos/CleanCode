using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class RectClass
    {
        private int _firstSide;     // First side
        private int _secondSide;    // Second side

        private DateTime _date;

        public RectClass(int firstSide, int secondSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;

            _date = DateTime.Now;
        }

        /*
         * Get field value of rectangle.
         */
        public int GetFieldValue()
        {
            return _firstSide * _secondSide;
        }

        /*
         * Get Duration of rectangle existance in milliseconds.
         */
        public int GetExistanceDurationInMilliSeconds()
        {
            var d = (DateTime.Now -_date);
            return (int)d.TotalMilliseconds;
        }

        /*
         * Get Duration of rectangle existance in seconds.
         */
        public int GetExistanceDurationInSeconds()
        {
            var d = (DateTime.Now - _date);
            return (int)d.TotalSeconds;
        }
    }
}
