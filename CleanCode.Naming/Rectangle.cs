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
            _a = A;
            _b = B;

            _createdAt = DateTime.Now;
        }

        public int CalculateArea()
        {
            return _a * _b;
        }

        private TimeSpan ExistenceTimeSpan() 
        {
            return DateTime.Now - _createdAt;
        }

        public int DurationOfExistence(bool InMilliseconds)
        {
            return InMilliseconds ? DurationOfExistenceInMilliseconds() : DurationOfExistenceInSeconds();
        }

        public int DurationOfExistenceInSeconds()
        {
            return (int)ExistenceTimeSpan().TotalSeconds;
        }

        public int DurationOfExistenceInMilliseconds()
        {
            return (int)ExistenceTimeSpan().TotalMilliseconds;
        }
    }
}
