using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class Rectangle
    {
        private int a;
        private int b;

        private DateTime createdAt;

        public Rectangle(int a, int B)
        {
            this.a = a;
            this.b = B;

            createdAt = DateTime.Now;
        }

        public int field()
        {
            return a * b;
        }

        // If duration should be in seconds
        public int durationOfExistence(bool @is)
        {
            var d = (createdAt - DateTime.Now);

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
