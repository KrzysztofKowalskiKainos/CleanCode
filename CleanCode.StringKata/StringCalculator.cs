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
            string[] numbers = input.Split(',');

            int sum = 0;
            foreach (string number in numbers) {
                sum += int.Parse(number);
            }

            return sum;
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
