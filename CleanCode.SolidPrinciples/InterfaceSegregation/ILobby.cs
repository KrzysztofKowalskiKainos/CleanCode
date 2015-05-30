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

        void MessageReceived(string player);

        IEnumerable<string> GetPlayerStatus(string player);

        void Confirm(Request request);

        Response Answer(Request request);

        void PausePlayerTimer(string player);

        void RefreshPlayerTimer(string player);

        void KickPlayer(string player);

        void AllOut();
    }

    public class Response { } 

    public class Request { }
}
