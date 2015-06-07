using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class Rectangular
    {
        // First side
        private int width;

        // Second side
        private int height;
        private DateTime dateOfCreation;

        public Rectangular(int width, int height)
        {
            this.width = width;
            this.height = height;

            dateOfCreation = DateTime.Now;
        }

        public int GetArea()
        {
            return width * height;
        }

        // If duration should be in seconds
        public int GetDurationOfExistence(TimeUnits unitOfTimeSpan)
        {
            var durationOfExistence = (DateTime.Now - dateOfCreation);
            var durationInUnits = typeof(TimeSpan).GetProperty("Total" + unitOfTimeSpan).GetValue(durationOfExistence);

            return Convert.ToInt32(durationInUnits);
        }
    }
}
