using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class Rect
    {
        // First side
        private int _firstSide;

        // Second side
        private int _secondSide;
        private DateTime _creationDate;

        public Rect(int FirstSide, int SecondSide)
        {
            _firstSide = FirstSide;
            _secondSide = SecondSide;

            _creationDate = DateTime.Now;
        }

        public int Field()
        {
            return _firstSide * _secondSide;
        }
        public int CreationDateToSeconds()
        {
           var d = (_creationDate - DateTime.Now);
           return Convert.ToInt32(d.TotalSeconds);
        }
        public int CreationDateToMiliSeconds()
        {
            var d = (_creationDate - DateTime.Now);
            return Convert.ToInt32(d.TotalMilliseconds);
        }
    }
}
