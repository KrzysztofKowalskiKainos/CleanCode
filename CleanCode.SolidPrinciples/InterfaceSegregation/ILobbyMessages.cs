namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    public interface ILobbyMessages
    {
        void MessageReceived(string player);

        void Confirm(Request request);

        Response Answer(Request request);
    }
}
