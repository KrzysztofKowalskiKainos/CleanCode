namespace CleanCode.SolidPrinciples
{
    public class ObservationPlace
    {
        public string Environment { get; internal set; }
        public PlaceType Type { get; internal set; }
        public string[] IgnoredSightings { get; internal set; }
        public string Message { get; internal set; }
    }
}