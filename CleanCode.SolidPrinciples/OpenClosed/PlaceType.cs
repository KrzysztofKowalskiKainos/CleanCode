namespace CleanCode.SolidPrinciples
{
    public class PlaceType
    {
        public static readonly PlaceType FOREST = new PlaceType("<Forest Sounds>", new[] { "|", "@" });
        public static readonly PlaceType OCEAN = new PlaceType("bul bul bul", new[] { "~" });

        PlaceType(string sounds, string[] ignoredSightings)
        {
            this.sounds = sounds;
            this.ignoredSightings = ignoredSightings;
        }

        private readonly string sounds;
        private readonly string[] ignoredSightings;

        public string Sounds { get { return sounds; } }
        public string[] IgnoredSightings { get { return ignoredSightings; } }
    }
}