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

        private TimeSpan existenceTimeSpan() 
        {
            return createdAt - DateTime.Now;
        }

        public int durationOfExistence(bool inMiliseconds)
        {
            return inMiliseconds ? durationOfExistenceInMiliseconds() : durationOfExistenceInSeconds();
        }

        public int durationOfExistenceInSeconds()
        {
            return (int)existenceTimeSpan().TotalSeconds;
        }

        public int durationOfExistenceInMiliseconds()
        {
            return (int)existenceTimeSpan().TotalMilliseconds;
        }
    }
}
