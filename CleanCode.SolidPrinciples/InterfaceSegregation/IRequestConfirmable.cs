using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    public interface IRequestConfirmable
    {
        Response Answer(Request request);
        void Confirm(Request request);
    }
}
