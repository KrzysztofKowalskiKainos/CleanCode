namespace CleanCode.SolidPrinciples
{
    public class PlaceType
    {
        public static readonly PlaceType FOREST = new PlaceType("<Forest Sounds>", new[] { "|", "@" });
        public static readonly PlaceType OCEAN = new PlaceType("bul bul bul", new[] { "~" });

        PlaceType(string sounds, string[] ignoredSightings)
        {
            _sounds = sounds;
            _ignoredSightings = ignoredSightings;
        }

        private readonly string _sounds;
        private readonly string[] _ignoredSightings;

        public string Sounds { get { return _sounds; } }
        public string[] IgnoredSightings { get { return _ignoredSightings; } }
    }
}