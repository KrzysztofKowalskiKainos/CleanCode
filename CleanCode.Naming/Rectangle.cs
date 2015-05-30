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

        public int Field
        {
            get
            {
                return _firstSide * _secondSize;
            }
        }

        public Rectangle(int firstSide, int secondSize)
        {
            _firstSide = firstSide;
            _secondSize = secondSize;
            _dateTime = DateTime.Now;
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
