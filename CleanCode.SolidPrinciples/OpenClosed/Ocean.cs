using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    class Ocean : PlaceType
    {
        private string[] ignoredSightings = new[] { "~" };
        private string result;
        public Ocean()
        {

            Console.WriteLine("bul bul bul");


        }
    public override string getEnvironement()
        {
            result = "Ocean";
            foreach (var ignored in ignoredSightings)
              result = result.Replace(ignored, string.Empty);

            return result;
        }
    }
}
