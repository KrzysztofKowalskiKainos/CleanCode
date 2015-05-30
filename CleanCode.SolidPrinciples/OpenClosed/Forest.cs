using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanCode.SolidPrinciples.OpenClosed;
namespace CleanCode.SolidPrinciples.OpenClosed
{
    class Forest : PlaceType
    {
        private string[] ignoredSightings = new[] { "|", "@" };
        string result;
        public Forest()
        {
            Console.WriteLine("<Forest Sounds>");
        }
        public override string getEnvironement()
        {
            result = "Forest";
            foreach (var ignored in ignoredSightings)
                result = result.Replace(ignored, string.Empty);
            return result;
        }

    }
}
