using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class Rect_Class
    {
        private int sideA;
        private int sideB;

        private DateTime actualTime;


        public Rect_Class(int sideA, int sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            actualTime = DateTime.Now;
        }

        public int Field()
        {
            return sideA * sideB;
        }

        // If duration should be in seconds
        public int DurationOfExistence(bool durationInSeconds)
        {
            var actualTime = (this.actualTime - DateTime.Now);

            if (durationInSeconds)
            {
                return (int)actualTime.TotalMilliseconds;
            }
            else
            {
                return (int)actualTime.TotalSeconds;
            }
        }
    }
}
