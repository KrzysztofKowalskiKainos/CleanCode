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
            if (0 == input.Length)
            {
                return 0;
            }

            return int.Parse(input);
        }
    }
}
