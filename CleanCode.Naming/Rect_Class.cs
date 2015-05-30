using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    enum TimeUnit { MiliSeconds, Seconds};

    class RectClass
    {
        private int _width, _height;
        private DateTime _creationDate;

        public RectClass(int width, int height)
        {
            _width = width;
            _height = height;
            _creationDate = DateTime.Now;
        }

        public int Field()
        {
            return _width * _height;
        }

        // If duration should be in seconds
        public int TimeOfLife(TimeUnit timeUnit)
        {
            var timeOfLife = (_creationDate - DateTime.Now);

            if (timeUnit  == TimeUnit.MiliSeconds)
            {
                return (int)timeOfLife.TotalMilliseconds;
            }
            else
            {
                return (int)timeOfLife.TotalSeconds;
            }
        }
    }
}
