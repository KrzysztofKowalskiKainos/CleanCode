using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CleanCode.Naming
{
    class Rectangle
    {
        // First side
        private int _a;

        // Second side
        private int _b;

        // Creation DateTime
        private DateTime _creationDate;

        public Rectangle(int a, int b)
        {
            _a = a;
            _b = b;

            _creationDate = DateTime.Now;
        }

        public int CalulateField()
        {
            return _a * _b;
        }

        public TimeSpan GetExistanceTime()
        {
            return (DateTime.Now - _creationDate);
        }

        // If duration should be in seconds
        public int GetExistanceDuration(bool isDurationInSeconds)
        {
            return isDurationInSeconds ? ObjDurationInMiliseconds() : ObjDurationInSeconds();
        }

        private int ObjDurationInSeconds (){
            return (int) GetExistanceTime().TotalSeconds;
        }

        private int ObjDurationInMiliseconds (){
            return (int) GetExistanceTime().TotalSeconds;
        }

    }
}
