using System.Linq;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class HolidayLaughterGenerator
    {
        private readonly string _laughSound;

        public HolidayLaughterGenerator(string laughSound)
        {
            _laughSound = laughSound;
        }

        public string GenerateLaugh(int nrOfTimes)
        {
            return string.Concat(Enumerable.Repeat(_laughSound, nrOfTimes));
        }
    }
}
