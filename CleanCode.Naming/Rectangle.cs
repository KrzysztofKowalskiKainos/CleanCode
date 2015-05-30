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

        public int Field()
        {
            return _a * _b;
        }

        private TimeSpan ExistenceTimeSpan() 
        {
            return _createdAt - DateTime.Now;
        }

        public int DurationOfExistence(bool InMiliseconds)
        {
            return InMiliseconds ? DurationOfExistenceInMiliseconds() : DurationOfExistenceInSeconds();
        }

        public int DurationOfExistenceInSeconds()
        {
            return (int)ExistenceTimeSpan().TotalSeconds;
        }

        public int DurationOfExistenceInMiliseconds()
        {
            return (int)ExistenceTimeSpan().TotalMilliseconds;
        }
    }
}
