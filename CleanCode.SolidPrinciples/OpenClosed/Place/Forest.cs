using System;

namespace CleanCode.SolidPrinciples.OpenClosed.Place
{
    class Forest : IPlace
    {

        public bool Observe(string environment)
        {
            var ignoredSightings = new[] { "|", "@" };

            var result = environment;
            foreach (var ignored in ignoredSightings)
                result = result.Replace(ignored, string.Empty);

            return result.Length > 0;
        }

        public string Sound()
        {
            return @"<Forest Sounds>";
        }
    }
}
