namespace CleanCode.SolidPrinciples.DependencyInversion
{
    class CopyingMachine
    {
        private readonly IPrinter _printer;

        public CopyingMachine(IPrinter printer)
        {
            _printer = printer;
        }

        public void Copy(string textToCopy, int nrOfCopies)
        {
            for(var i=0; i<nrOfCopies; i++)
            {
                _printer.Print(textToCopy);
            }
        }
    }
}
