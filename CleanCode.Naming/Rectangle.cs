using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class Rectangle
    {
        private int firstSide;
        private int secondSide;
        private DateTime currentDate;

        public Rectangle(int firstSide, int secondSide)
        {
            this.firstSide = firstSide;
            this.secondSide = secondSide;
            this.currentDate = DateTime.Now;
        }

        public int getField()
        {
            return this.firstSide * this.secondSide;
        }

        // If duration should be in seconds
        public int durationOfExistence(bool inMilliseconds)
        {
            var timeDifference = (this.currentDate - DateTime.Now);

            if (inMilliseconds)
            {
                return (int)timeDifference.TotalMilliseconds;
            }
            else
            {
                return (int)timeDifference.TotalSeconds;
            }
        }
    }
}
