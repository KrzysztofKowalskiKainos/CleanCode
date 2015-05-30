namespace CleanCode.SolidPrinciples
{
    public class Forrest : ObservationPlace
    {
        public Forrest() : base(PlaceType.Forest, "<Forest Sounds>", new[] { "|", "@" })
        { }
    }
}