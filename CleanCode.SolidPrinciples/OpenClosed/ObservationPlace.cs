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

        public bool IsSomethingObserved()
        {
            return place.ObservedElements(this.environment) > 0;
        }
    }
}