using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.DependencyInversion
{
    interface IPrinters
    {
         void Print(string textToCopy);
    }
}
