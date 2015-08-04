using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCode.SolidPrinciples.SingleResponsibility;

namespace CleanCode.SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            StringHolidayLaughGenerator stringHolidaysLaughGenerator = new StringHolidayLaughGenerator("haha");
            stringHolidaysLaughGenerator.GenerateLaugh(3);

            StringReferenceCounter refernceCounter = new StringReferenceCounter("aa", "bb");
            refernceCounter.CountReferences("a");
        }
    }
}
