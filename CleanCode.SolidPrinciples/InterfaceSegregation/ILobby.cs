using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    public interface ILobby
    {
       

        void AddPlayer(string newPlayer);

        void MessageReceived(string player);

        IEnumerable<string> GetPlayerStatus(string player);


        void KickPlayer(string player);

       
    }

    
}
