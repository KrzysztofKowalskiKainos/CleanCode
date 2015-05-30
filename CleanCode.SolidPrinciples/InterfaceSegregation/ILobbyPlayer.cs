using System.Collections.Generic;

namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    interface ILobbyPlayer
    {
        IEnumerable<string> GetPlayerStatus(string player);

        void KickPlayer(string player);

        void PausePlayerTimer(string player);

        void RefreshPlayerTimer(string player);
    }
}
