namespace CleanCode.SolidPrinciples.OpenClosed.Place
{
    public interface IPlace
    {
        string Sound();

        int ObservedElements(string environment);
    }
}
