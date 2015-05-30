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
            return _firstSide * _secondSide;
        }

        public int getDuration(bool inSeconds)
        {
            var duration = (_currentDate - DateTime.Now);

            if (inSeconds)
            {
                return (int)duration.TotalSeconds;
            }
            else
            {
                return (int)duration.TotalMilliseconds;
            }
        }
    }
}
