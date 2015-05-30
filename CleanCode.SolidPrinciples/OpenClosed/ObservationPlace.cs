using CleanCode.SolidPrinciples.OpenClosed.Place;

namespace CleanCode.SolidPrinciples
{
    public class ObservationPlace
    {
        private string Environment { get; set; }
        private IPlace Place { get; set; }

        internal bool Observe()
        {
           return Place.Observe(this.Environment);
        }
    }
}