using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.StringKata
{
    public class StringCalculator
    {
        private string _defaultSeparator = ",";

        public int Add(string input)
        {
            if (IsStringEmpty(input))
            {
                return HandleEmptyString();
            }

            return HandleString(input);
        }

        private int HandleString(string input)
        {
            string[] elements = ExtractElements(input);

            return HandleElements(elements);
        }

        private int HandleElements(string[] elements)
        {
            List<int> numbers = ConvertToNumbers(elements);

            ValidateNumbers(numbers);

            numbers = FilterOutTooBigNumbers(numbers);

            return numbers.Sum();
        }

        private static List<int> FilterOutTooBigNumbers(List<int> numbers)
        {
            numbers = numbers.Where(number => number < 1000).ToList();
            return numbers;
        }

        private static void ValidateNumbers(List<int> numbers)
        {
            int[] negatives = numbers.Where(number => number < 0).ToArray();
            if (negatives.Length > 0)
            {
                throw new System.ArgumentException("Negatives not allowed: " + String.Join(", ", negatives));
            }
        }

        private List<int> ConvertToNumbers(string[] elements)
        {
            List<int> numbers = new List<int>();
            foreach (string element in elements)
            {
                numbers.Add(HandleElement(element));
            }
            return numbers;
        }

        private int HandleElement(string element)
        {
            return int.Parse(element);
        }

        private string[] ExtractElements(string input)
        {
            input = Normalize(input);

            return input.Split(new string[] { _defaultSeparator }, StringSplitOptions.None);
        }

        private string Normalize(string input)
        {
            input = RemoveSeparatorConfiguration(input);
            input = ReplaceSeparators(input);

            return input;
        }

        private string RemoveSeparatorConfiguration(string input)
        {
            _defaultSeparator = ",";

            if (input.StartsWith("//"))
            {
                _defaultSeparator = input[2].ToString();
                input = input.Substring(4);
            }

            return input;
        }

        private string ReplaceSeparators(string input)
        {
            return input.Replace("\n", _defaultSeparator);
        }

        private int HandleEmptyString()
        {
            return 0;
        }

        private bool IsStringEmpty(string input)
        {
            return 0 == input.Length;
        }
    }
}
