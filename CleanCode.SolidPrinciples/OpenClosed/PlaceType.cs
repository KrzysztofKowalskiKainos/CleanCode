using System;

namespace CleanCode.SolidPrinciples
{
    class PlaceType
    {
        public abstract string[] GetIgnoredSightings();
    }

    class Forest : PlaceType
    {
        public override string[] GetIgnoredSightings()
        {
            Console.WriteLine("<Forest Sounds>");

            return new[] { "|", "@" };
        }
    }

    class Ocean : PlaceType
    {
        public override string[] GetIgnoredSightings()
        {
            Console.WriteLine("bul bul bul");

            return new[] { "~" };
        }
    }
}