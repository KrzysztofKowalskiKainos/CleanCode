using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.StringKata
{
    public class StringCalculator
    {
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
            char defaultSeparator = ',';

            input = input.Replace('\n', defaultSeparator);

            return input.Split(defaultSeparator);
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
