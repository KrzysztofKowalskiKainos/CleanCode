using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CleanCode.StringKata
{
    public class StringCalculator
    {

        private int sum;
        private String delimiterRegex="\\[(.*?)]";
        private String[] delimitedString;
        private List<Int32> negatives;


        private String getCustomDelimiter(String input)
        {
            
            String firstLine = input.Split('\n').FirstOrDefault();
            String result = firstLine.Substring(2);
            Regex multipleDelimeters = new Regex(delimiterRegex);
            Match match = multipleDelimeters.Match(result);
            if (match.Success)
            {
                Console.WriteLine(match.Value);
                return match.Value;
            }
            return result;
           
        }

        private String removeCustomDelimiter(String input)
        {
            int index = input.IndexOf("\n");
            return input = input.Substring(index + 1);
        }

        private bool hasMultipleDelimiters(String input)
        {
            Regex multipleDelimeters = new Regex(delimiterRegex);
            Match match = multipleDelimeters.Match(input);
            if (match.Success)
            {
                return true;
            }
            return false;
        }

        private string[] getMultipleDelimiters(String input)
        {
           
            List<string> delimiters = new List<string>();
            Regex multipleDelimeters = new Regex(delimiterRegex);
            MatchCollection matches = multipleDelimeters.Matches(input);
            foreach (Match match in matches) 
            {
                delimiters.Add(match.Groups[1].Value);
            }
            
            return delimiters.ToArray();
        }



        private bool hasCustomDelimiter(String input) 
        {
            return input.StartsWith("//");
        }

        public int Calculate(string input)
        {
            sum=0;
            negatives = new List<Int32>();
            if (input.Length == 0)
            {
             
                return 0;
            }
        
            char[] delimiterChars = { ',', '\n' };
            if (hasMultipleDelimiters(input))
            {
                string[] multipleDelimiter = getMultipleDelimiters(input);
                input = removeCustomDelimiter(input);
                delimitedString = input.Split(multipleDelimiter, StringSplitOptions.None);
            }
            else if (hasCustomDelimiter(input))
            {
                String customDelimiter = getCustomDelimiter(input);
                input=removeCustomDelimiter(input);
                delimitedString = input.Split(new string[] { customDelimiter }, StringSplitOptions.None);
               
            }
            else
            {
                delimitedString = input.Split(delimiterChars);
            }

            for (int i = 0; i < delimitedString.Length; i++)
            {
                int number = Int32.Parse(delimitedString[i]);
                if (number < 0)
                {
                    negatives.Add(number);
                }
                if (number <= 1000)
                {
                    sum += number;
                }
                
            }
            if (negatives.Count > 0)
            {
                
                throw new Exception("negatives: "+string.Join(" ", negatives));
            }
            return sum;
        }

       
    }
}
