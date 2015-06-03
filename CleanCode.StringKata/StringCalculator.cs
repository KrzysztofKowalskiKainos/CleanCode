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
            if (1 == input.Length)
            {
                return 1;
            }
            return 0;
        }
    }
}
