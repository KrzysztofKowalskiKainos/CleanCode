using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.StringKata
{
    public class StringCalculator
    {
        public static int Calculate(string input)
        {
            if (IsStringEmpty(input))
            {
                return HandleEmptyString();
            }

            return HandleString(input);
        }

        private static int HandleString(string input)
        {
            return int.Parse(input);
        }

        private static int HandleEmptyString()
        {
            return 0;
        }

        private static bool IsStringEmpty(string input)
        {
            return 0 == input.Length;
        }
    }
}
