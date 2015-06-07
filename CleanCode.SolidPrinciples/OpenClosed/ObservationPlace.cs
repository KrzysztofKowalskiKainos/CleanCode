using CleanCode.SolidPrinciples.OpenClosed;
namespace CleanCode.SolidPrinciples
{
    public abstract class ObservationPlace: IObservationPlace
    {
        public string Environment { get; internal set; }
        public PlaceType Type { get; internal set; }
        public string[] IgnoredSightings { get; internal set; }
        public string Message { get; internal set; }

        public abstract bool ObservePlace();
        
    }
}