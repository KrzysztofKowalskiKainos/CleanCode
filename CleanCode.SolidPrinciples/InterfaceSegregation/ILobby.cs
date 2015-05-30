using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    public interface ILobby
    {
        void AllIn();

        void AddPlayer(string newPlayer);

        IEnumerable<string> GetPlayerStatus(string player);

        void KickPlayer(string player);

        void AllOut();
    }

    public interface IPlayerTimer
    {
        void PausePlayerTimer(string player);

        void RefreshPlayerTimer(string player);
    }

    public interface IPlayerMessager
    {

        void Confirm(Request request);

        void MessageReceived(string player);

        Response Answer(Request request);

    }

    public class Response
    {
    }

    public class Request
    {
    }

}