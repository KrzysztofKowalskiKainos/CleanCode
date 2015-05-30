using System;

namespace CleanCode.SolidPrinciples.OpenClosed.Place
{
    internal class Ocean : IPlace
    {
        public int ObservedElements(string environment)
        {
            var ignoredSightings = new[] {"~"};
            var result = environment;
            foreach (var ignored in ignoredSightings)
                result = result.Replace(ignored, string.Empty);

            return result.Length;
        }

        public string Sound()
        {
            return @"bul bul bul";
        }
    }
}
