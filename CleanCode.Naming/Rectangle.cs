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
        private DateTime _createdAt;

        public Rectangle(int firstSide, int secondSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _createdAt = DateTime.Now;
        }

        public int getField()
        {
            return _firstSide*_secondSide;
        }

        public int durationOfExistence(bool isDurationInSecond)
        {
            var duration = (DateTime.Now - _createdAt);

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
