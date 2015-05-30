using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    enum TimeUnit { Seconds, Miliseconds };

    class Rectangle
    {
        private int _height;
        private int _width;

        private DateTime createdOn;

        public Rectangle(int height, int width)
        {
            _height = height;
            _width = width;

            createdOn = DateTime.Now;
        }

        /// <summary>
        /// Calculate rectangle field.
        /// </summary>
        /// <returns></returns>
        public int area()
        {
            return _height * _width;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="timeUnit"></param>
        /// <returns></returns>
        public int durationOfExistence(TimeUnit timeUnit)
        {
            var duration = (DateTime.Now - createdOn);

            if (timeUnit == TimeUnit.Miliseconds)
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
