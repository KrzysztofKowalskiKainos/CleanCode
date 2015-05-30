using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    class OceanObserver : IObserver
    {
        public bool Observe(string Environment)
        {
            string result;
            string[] ignoredSightings = ignoredSightings = new[] { "~" };
            Console.WriteLine("bul bul bul");
            result = Environment;
            foreach (var ignored in ignoredSightings)
                result = result.Replace(ignored, string.Empty);

            return result.Length > 0;
        }
    }
}
