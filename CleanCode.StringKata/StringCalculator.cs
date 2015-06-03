using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.StringKata
{
    public class StringCalculator
    {
        private static char _defaultSeparator = ',';

        public static int Add(string input)
        {
            if (IsStringEmpty(input))
            {
                return HandleEmptyString();
            }

            return HandleString(input);
        }

        private static int HandleString(string input)
        {
            string[] elements = ExtractElements(input);

            return HandleElements(elements);
        }

        private static int HandleElements(string[] elements)
        {
            int sum = 0;
            foreach (string element in elements)
            {
                sum += HandleElement(element);
            }

            return sum;
        }

        private static int HandleElement(string element)
        {
            return int.Parse(element);
        }

        private static string[] ExtractElements(string input)
        {
            input = ReplaceSeparators(input);

            return input.Split(_defaultSeparator);
        }

        private static string ReplaceSeparators(string input)
        {
            return input.Replace('\n', _defaultSeparator);
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
