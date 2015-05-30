using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.OpenClosed
{
    class ForestObserver : IObserver
    {
        public bool Observe(string Environment)
        {
            string[] ignoredSightings;
            string result;
            ignoredSightings = new[] { "|", "@" };
            Console.WriteLine("<Forest Sounds>");
            result = Environment;
            foreach (var ignored in ignoredSightings)
                result = result.Replace(ignored, string.Empty);

            return result.Length > 0;

        }
    }
}