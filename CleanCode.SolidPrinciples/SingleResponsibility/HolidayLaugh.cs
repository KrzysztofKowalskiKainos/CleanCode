using System.Linq;

namespace CleanCode.SolidPrinciples.SingleResponsibility
{
    class HolidayLaugh
    {
        private string _laughSound;

        HolidayLaugh(string laughSound)
        {
            _laughSound = laughSound;
        }

        public string GenerateLaugh(int nrOfTimes)
        {
            return string.Concat(Enumerable.Repeat(_laughSound, nrOfTimes));
        }
    }
}
