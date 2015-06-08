using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    interface ILobbySinglePlayerActions
    {
        void AddPlayer(string newPlayer);

        void PausePlayerTimer(string player);

        void RefreshPlayerTimer(string player);

        void KickPlayer(string player);

        IEnumerable<string> GetPlayerStatus(string player);
    }
}
