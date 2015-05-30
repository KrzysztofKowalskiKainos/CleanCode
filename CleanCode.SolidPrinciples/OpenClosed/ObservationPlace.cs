using System;
namespace CleanCode.SolidPrinciples
{
    public class ObservationPlace
    {
        public string Environment { get; internal set; }
        public PlaceType Type { get; internal set; }

        public int lengthOfIngoredSigns(string[] ignoredSigns, string soundOfEnviroment)
        {
            string result;
            if ((ignoredSigns==null) || (soundOfEnviroment==null))
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