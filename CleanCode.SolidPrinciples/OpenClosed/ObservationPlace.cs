using System;
namespace CleanCode.SolidPrinciples
{
    public class ObservationPlace
    {
        public string Environment { get; internal set; }
        public PlaceType Type { get; internal set; }

        public int LengthOfIngoredSigns(string[] ignoredSigns, string soundOfEnviroment)
        {
            string result;
            if (this.Type != PlaceType.Forest && this.Type != PlaceType.Ocean)
            {
                throw new InvalidOperationException("Unknown place");
            }
            Console.WriteLine(soundOfEnviroment);
            result = this.Environment;
            foreach (var ignored in ignoredSigns)
                result = result.Replace(ignored, string.Empty);

            return result.Length;
         
     }
    }
}