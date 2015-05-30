using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class Rectangle
    {
        private int _x;
        private int _y;
        private DateTime _dateTime;


        public Rectangle(int x, int y)
        {
            _x  = x;
            _y = y;
            _dateTime = DateTime.Now;
        }

        public int Area()
        {
            return _x * _y;
        }

        public int TimeExistenceInSeconds()
        {
            var dateTimeNow = _dateTime - DateTime.Now;
            return (int)dateTimeNow.TotalSeconds;
        }

        public int TimeExistenceInMilliseconds()
        {
            var dateTimeNow = _dateTime - DateTime.Now;
            return (int)dateTimeNow.TotalMilliseconds;
        }
    }
}

           