namespace CleanCode.SolidPrinciples
{
    abstract public class ObservationPlace
    {
        public string Environment { get; internal set; }
        public PlaceType Type { get; internal set; }
        public string Sound { get; internal set; }

        protected string[] ignoredSightings;

        public string GetSightings()
        {
            string result;

            result = Environment;
            foreach (var ignored in ignoredSightings)
            {
                result = result.Replace(ignored, string.Empty);
            }
            return result;
        }

        public bool HasSightings()
        {
            return GetSightings().Length > 0;
        }

        protected ObservationPlace(PlaceType Type, string Sound, string[] ignoredSightings)
        {
            this.Type = Type;
            this.Sound = Sound;
            this.ignoredSightings = ignoredSightings;
        }
    }
}