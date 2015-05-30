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
        void MessageReceived(string player);
        void Confirm(Request request);
        Response Answer(Request request);
        void AllOut();
    }
    public interface IPlayer
    {
        void AddPlayer(string newPlayer);
        void KickPlayer(string player);
        IEnumerable<string> GetPlayerStatus(string player);
    }

    public interface IPlayerTimer
    {
        void PausePlayerTimer(string player);
        void RefreshPlayerTimer(string player);
    }


    public class Response { } 

    public class Request { }
}
