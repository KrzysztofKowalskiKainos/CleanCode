using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class Rectangle
    {
        
        private int _firstSide;
        private int _secondSide;
        private DateTime _currentDate;

        public Rectangle(int firstSide, int secondSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;

            _currentDate = DateTime.Now;
        }

        public int getField()
        {
            return _firstSide*_secondSide;
        }

        // If duration should be in seconds
        public int durationOfExistence(bool isDurationInSecond)
        {
            var duration = (DateTime.Now - _currentDate);

            if (isDurationInSecond)
            {
                return (int)duration.TotalMilliseconds;
            }
            else
            {
                return (int)duration.TotalSeconds;
            }
        }
    }
}
