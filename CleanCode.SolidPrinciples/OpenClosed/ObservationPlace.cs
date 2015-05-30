using CleanCode.SolidPrinciples.OpenClosed.Place;

namespace CleanCode.SolidPrinciples
{
    public class ObservationPlace
    {
        public string Environment { get; internal set; }
        public IPlace Place { get; internal set; }

        internal bool Observe()
        {
           return Place.Observe(this.Environment);
        }
    }
}