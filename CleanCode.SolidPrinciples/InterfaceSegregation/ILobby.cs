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
  
        void AllOut();
    }

    public interface Player
    {
        void PausePlayerTimer(string player);

        void AddPlayer(string newPlayer);

        void RefreshPlayerTimer(string player);

        void KickPlayer(string player);

        void MessageReceived(string player);

        IEnumerable<string> GetPlayerStatus(string player);

    }

    public interface Messaging
    {
        Response Answer(Request request);

        void Confirm(Request request);


    }

    public class Response { } 

    public class Request { }
}
