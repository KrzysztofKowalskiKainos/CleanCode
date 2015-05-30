using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class RectClass
    {
        // First side
        private int FirstSide;

        // Second side
        private int SecondSide;
        private DateTime CreationDate;

        public RectClass(int FirstSide, int SecondSide)
        {
            this.FirstSide = FirstSide;
            this.SecondSide = SecondSide;

            CreationDate = DateTime.Now;
        }

        public int Field()
        {
            return FirstSide * SecondSide;
        }
        public int CreationDateToSeconds()
        {
           var d = (CreationDate - DateTime.Now);
           return Convert.ToInt32(d.TotalSeconds);
        }
        public int CreationDateToMiliSeconds()
        {
            var d = (CreationDate - DateTime.Now);
            return Convert.ToInt32(d.TotalMilliseconds);
        }
    }
}
