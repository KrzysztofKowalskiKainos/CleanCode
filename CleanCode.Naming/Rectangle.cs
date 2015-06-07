using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class Rectangle
    {
        private int sideA;
        private int sideB;

        private DateTime actualTime;


        public Rectangle(int sideA, int sideB)
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
            var actualTime = (DateTime.Now - this.actualTime);

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
