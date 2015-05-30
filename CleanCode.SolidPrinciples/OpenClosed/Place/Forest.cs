namespace CleanCode.SolidPrinciples.OpenClosed.Place
{
    class Forest : IPlace
    {
        public int ObservedElements(string environment)
        {
            var ignoredSightings = new[] { "|", "@" };

            var result = environment;
            foreach (var ignored in ignoredSightings)
                result = result.Replace(ignored, string.Empty);

            return result.Length;
        }

        public string Sound()
        {
            return @"<Forest Sounds>";
        }
    }
}
