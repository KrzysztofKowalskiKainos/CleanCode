using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    enum TimeUnit { MiliSeconds, Seconds};

    class Rectangle
    {
        private int _width, _height;
        private DateTime _creation;

        public Rectangle(int width, int height)
        {
            _width = width;
            _height = height;
            _creation = DateTime.Now;
        }

        public int Area()
        {
            return _width * _height;
        }

        // If duration should be in seconds
        public int InstanceLifeTime(TimeUnit timeUnit)
        {
            var instanceTimeOfLife = (DateTime.Now - _creation);

            if (timeUnit  == TimeUnit.MiliSeconds)
            {
                return (int)instanceTimeOfLife.TotalMilliseconds;
            }
            else
            {
                return (int)instanceTimeOfLife.TotalSeconds;
            }
        }
    }
}
