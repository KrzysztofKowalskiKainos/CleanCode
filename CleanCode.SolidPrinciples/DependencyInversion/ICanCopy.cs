using System;

namespace CleanCode.SolidPrinciples.DependencyInversion
{

    public interface ICanCopy
    {
        public void Copy(string textToCopy, int nrOfCopies);
    }
}