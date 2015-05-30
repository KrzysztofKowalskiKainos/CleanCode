using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class Rectangle
    {
        private int _a;
        private int _b;

        private DateTime _createdAt;

        public Rectangle(int A, int B)
        {
            this._a = A;
            this._b = B;

            _createdAt = DateTime.Now;
        }

        public int field()
        {
            return _a * _b;
        }

        private TimeSpan existenceTimeSpan() 
        {
            return _createdAt - DateTime.Now;
        }

        public int durationOfExistence(bool InMiliseconds)
        {
            return InMiliseconds ? durationOfExistenceInMiliseconds() : durationOfExistenceInSeconds();
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
