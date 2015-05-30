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

    public interface IPlayer
    {
        void PausePlayerTimer(string player);

        void AddPlayer(string newPlayer);

        void RefreshPlayerTimer(string player);

        void KickPlayer(string player);  

        IEnumerable<string> GetPlayerStatus(string player);

    }

    public interface IMessaging
    {
        Response Answer(Request request);

        void MessageReceived(string player);

        void Confirm(Request request);


    }

    public class Response { } 

    public class Request { }
}
