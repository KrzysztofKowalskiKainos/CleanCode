using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class RectangleClass
    {
        // First side
        private int _a;

        // Second side
        private int _b;

        // Creation DateTime
        private DateTime _creationDate;

        public RectangleClass(int a, int b)
        {
            _a = a;
            _b = b;

            _creationDate = DateTime.Now;
        }

        public int GetField()
        {
            return _a * _b;
        }

        // If duration should be in seconds
        public int GetExistanceDuration(bool isDurationInSeconds)
        {
            var objectDuration = (_creationDate - DateTime.Now);

            if (isDurationInSeconds)
            {
                
                return (int)objectDuration.TotalSeconds;
            }
            else
            {
                return (int)objectDuration.TotalMilliseconds;
            }
        }
    }
}
