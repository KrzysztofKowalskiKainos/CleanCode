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

        private DateTime _createDate;

        public Rectangle(int firstSide, int secondSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;

            _createDate = DateTime.Now;
        }

        public int Field
        {
            get
            {
                return _firstSide * _secondSide;
            }
        }

        public int getExistenceDurationInSeconds() 
        {
            TimeSpan existenceDuration = _createDate - DateTime.Now;
            return (int) existenceDuration.TotalSeconds;
        }

        public int getExistenceDurationInMiliseconds()
        {
            TimeSpan existenceDuration = _createDate - DateTime.Now;
            return (int) existenceDuration.TotalMilliseconds;
        }
    }
}
