using System;

namespace CleanCode.Naming
{
    class Rectangle
    {
        #region Private fields

        private int _firstSide;

        private int _secondSize;

        private DateTime _dateTime;

        #endregion

        public Rectangle(int firstSide, int secondSize)
        {
            _firstSide = firstSide;
            _secondSize = secondSize;
            _dateTime = DateTime.Now;
        }

        public int Field()
        {
            return _firstSide * _secondSize;
        }

        public int ExistenceTimeInSeconds()
        {
            var dateTimeNow = _dateTime - DateTime.Now;
            return (int)dateTimeNow.TotalSeconds;
        }

        public int ExistenceTimeInMilliseconds()
        {
            var dateTimeNow = _dateTime - DateTime.Now;
            return (int)dateTimeNow.TotalMilliseconds;
        }
    }
}
