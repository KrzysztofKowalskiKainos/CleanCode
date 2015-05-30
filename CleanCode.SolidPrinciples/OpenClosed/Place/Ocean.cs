using System;

namespace CleanCode.SolidPrinciples.OpenClosed.Place
{
    internal class Ocean : IPlace
    {
        public bool Observe(string environment)
        {
            var ignoredSightings = new[] {"~"};
            Console.WriteLine("bul bul bul");

            var result = environment;
            foreach (var ignored in ignoredSightings)
                result = result.Replace(ignored, string.Empty);

            return result.Length > 0;
        }
    }
}
