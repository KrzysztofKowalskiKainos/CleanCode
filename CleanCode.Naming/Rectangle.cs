using System;

namespace CleanCode.Naming
{
    class Rectangle
    {
        #region Private fields

        private readonly int _firstSide;

        private readonly int _secondSide;

        private readonly DateTime _creationDate;

        #endregion

        public int Field
        {
            get
            {
                return _firstSide * _secondSide;
            }
        }

        public Rectangle(int firstSide, int secondSide)
        {
            _firstSide = firstSide;
            _secondSide = secondSide;
            _creationDate = DateTime.Now;
        }

        public int ExistenceTimeInSeconds()
        {
            var dateTimeNow = _creationDate - DateTime.Now;
            return (int)dateTimeNow.TotalSeconds;
        }

        public int ExistenceTimeInMilliseconds()
        {
            var dateTimeNow = _creationDate - DateTime.Now;
            return (int)dateTimeNow.TotalMilliseconds;
        }
    }
}
