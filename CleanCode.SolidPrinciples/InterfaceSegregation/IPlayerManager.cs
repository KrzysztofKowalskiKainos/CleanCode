using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    public interface IPlayerManager
    {
        void KickPlayer(string player);

        void AddPlayer(string newPlayer);

        IEnumerable<string> GetPlayerStatus(string player);
    }
}
