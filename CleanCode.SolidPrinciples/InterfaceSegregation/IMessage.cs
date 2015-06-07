using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    public interface IMessage
    {
        void MessageReceived(string player);
        void Confirm(Request request);
        Response Answer(Request request);
    }
}
