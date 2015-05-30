using CleanCode.SolidPrinciples.OpenClosed.Place;

namespace CleanCode.SolidPrinciples
{
    public class ObservationPlace
    {
        private string environment { get; set; }
        private IPlace place { get; set; }

        internal string Sound()
        {
            return place.Sound();
        }

        internal bool Observe()
        {
           return place.Observe(this.environment);
        }
    }
}