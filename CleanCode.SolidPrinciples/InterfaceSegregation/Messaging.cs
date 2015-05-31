using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    interface IMessaging
    {
        void Confirm(Request request);
        Response Answer(Request request);
        void MessageReceived(string player);
    }
}
