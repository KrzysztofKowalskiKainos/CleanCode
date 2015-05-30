using System;

namespace CleanCode.SolidPrinciples.Liskov
{
    public class Walker
    {
        public virtual void Walk()
        {
            Console.WriteLine("Just walkin'");
        }
    }
}
