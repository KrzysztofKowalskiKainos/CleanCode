using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples.Liskov
{
    class Runner : IWalker, IRunner
    {
        public void Run()
        {
            Console.WriteLine("pant pant pant");
        }

        public virtual void Walk()
        {
            Console.WriteLine("Just walkin'");
        }
    }
}
