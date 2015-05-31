using System;
namespace CleanCode.SolidPrinciples
{
    public class ObservationPlace
    {
        public string environment { get; internal set; }
        public PlaceType Type { get; internal set; }
        protected string[] ignoredSightings = new[] {"Observation Place"};
        protected string environmentSound;
        public int getLength()
        {
            Console.WriteLine(environmentSound);
            string result=environment;
            foreach (var ignored in ignoredSightings)
                result = result.Replace(ignored, string.Empty);
            return result.Length;
        }
    }
}