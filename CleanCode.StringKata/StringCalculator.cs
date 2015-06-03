using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.StringKata
{
    public class StringCalculator
    {
        private List<string> _separators = new List<string>();

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
            input = ConfigureSeparator(input);
            return input.Split(_separators.ToArray(), StringSplitOptions.None);
        }

        private string ConfigureSeparator(string input)
        {
            if (input.StartsWith("//"))
            {
                input = ExtractSeparators(input);
            }
            else
            {
                SetupDefaultSeparators();
            }

            AddAlwaysUsedSeparators();

            return input;
        }

        private void AddAlwaysUsedSeparators()
        {
            _separators.Add("\n");
        }

        private void SetupDefaultSeparators()
        {
            _separators.Add(",");
        }

        private string ExtractSeparators(string input)
        {
            input = input.Substring(2);

            int separatorsLength = input.IndexOf('\n');
            string separators = input.Substring(0, separatorsLength);

            if (separators.StartsWith("[") && separators.EndsWith("]"))
            {
                separators = separators.Substring(1, separators.Length - 2);
            }

            foreach (string separator in separators.Split(new string[] { "][" }, StringSplitOptions.None))
            {
                _separators.Add(separator);
            }

            input = input.Substring(separatorsLength + 1);
            return input;
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
