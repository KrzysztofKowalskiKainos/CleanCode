using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    interface Message
    {
        void MessageReceived(string player);

        void Confirm(Request request);

        Response Answer(Request request);
    }


    public class Response { }

    public class Request { }
}
