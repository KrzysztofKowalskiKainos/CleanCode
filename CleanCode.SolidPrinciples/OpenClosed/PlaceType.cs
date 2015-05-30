using System;

namespace CleanCode.SolidPrinciples
{
    public abstract class PlaceType
    {
        abstract public string[] GetIgnoredSightings();
    }

    public class Forest : PlaceType
    {
        public override string[] GetIgnoredSightings()
        {
            Console.WriteLine("<Forest Sounds>");

            return new[] { "|", "@" };
        }
    }

    public class Ocean : PlaceType
    {
        public override string[] GetIgnoredSightings()
        {
            Console.WriteLine("bul bul bul");

            return new[] { "~" };
        }
    }
}