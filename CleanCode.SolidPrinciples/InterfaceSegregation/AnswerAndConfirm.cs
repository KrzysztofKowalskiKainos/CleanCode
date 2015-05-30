using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.InterfaceSegregation
{
    interface AnswerAndConfirm
    {
        void Confirm(Request request);
        Response Answer(Request request);
    }
}
