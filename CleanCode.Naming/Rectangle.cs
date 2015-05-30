using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class Rectangle
    {
        // First side
        private int _a;

        // Second side
        private int b;
        private DateTime CDATE;

        public Rectangle(int a, int B)
        {
            _a = a;
            b = B;

            CDATE = DateTime.Now;
        }

        public int field()
        {
            return _a * b;
        }

        // If duration should be in seconds
        public int durationOfExistence(bool @is)
        {
            var d = (CDATE - DateTime.Now);

            if (@is)
            {
                return (int)d.TotalMilliseconds;
            }
            else
            {
                return (int)d.TotalSeconds;
            }
        }
    }
}
