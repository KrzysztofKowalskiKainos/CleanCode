using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.SolidPrinciples
{
    class StringHolidayCountReferences
    {
        //------------------------------------ MEMBERS ---------------------------------------//
        private string[] references;

        //------------------------------------ METHODS ---------------------------------------//
                                            //constructors
        StringHolidayCountReferences()
        {
            references = null;
        }
        StringHolidayCountReferences(string reference)
        {
            if (references == null)
                references = new string[1];
            else
            {
                if (references != null)
                    for (int a = 0; a < references.GetLength(0); a++)
                    {
                        if (references[a] == null)
                        {
                            references[a] = reference;
                            break;
                        }
                    }
            }
        }
        StringHolidayCountReferences(string[] references)
        {
            for (int a = 0; a < references.GetLength(0); a++)
                this.references[a] = references[a];
        }

                                            //setters
        public void set_Reference(string reference, short index)
        {
            references[index] = reference;
        }

                                            //operations
        public int CountReferences(string inputString)
        {
            return references.Sum(r => Regex.Matches(inputString.ToLower(), Regex.Escape(r.ToLower())).Count);
        }

    }
}
