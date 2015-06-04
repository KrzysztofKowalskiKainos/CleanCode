using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCode.StringKata
{
    public class StringCalculator
    {
        public int Add(string input)
        {
            List<string> negatives  = new List<string>();
            string[] separator =new string[]{","};

            if (input.Length == 0)
                return 0;

            if (checkDeclaredSeparator(input))
            {
                separator = getSeparator(input);
                removeSeparateDeclaration(ref input);
            }
            else
            {
            
                if (input.Split('\n').Length> 0)
                    input = input.Replace('\n', ',');
            }
                
            if (isOnlyOneElement(input, separator))
                return computeOneElement(input);
            else
            {
                int result = computeMultiElements(input,separator,ref negatives);

                try
                {
                    checkNegatives(negatives);

                }catch(Exception ex)
                {
                    throw ex;
                }


                return result;
            }
 
        }


        public string[] getSeparator(string input)
        {
            if (input.Contains('['))
            {
                input = input.Substring(3, input.IndexOf('\n') - 4);
              //  input = input.Replace("]", string.Empty);

                string[] separator = input.Split(new string[]{"]["},StringSplitOptions.None);
                return separator;
            }
            else
            {
                string[] separator = new string[] { input.Substring(2, input.IndexOf('\n') - 2) };
                return separator;
            }
        }

        public bool checkDeclaredSeparator(string input)
        {
            if (input.Length > 2)
            {
                if (input.Substring(0, 2) == "//")
                    return true;
            }
                return false;
        }
        public void removeSeparateDeclaration(ref string input)
        {
            input = input.Substring(input.IndexOf('\n') + 1);
        }
        public int computeOneElement(string input)
        {
                if (int.Parse(input) > 1000)
                    return 0;
                else
                    return int.Parse(input);
        }
        public bool isOnlyOneElement(string input, string[] separator)
        {
            foreach (string sep in separator)
            {
                if (input.Contains(sep))
                    return false;
            }
            return true;
        }
        public int computeMultiElements(string input, string[] separator, ref List<string> negatives)
        {
            string[] splittedInput = input.Split(separator,StringSplitOptions.None);

            int result = 0;
            foreach (string number in splittedInput)
            {
                if (int.Parse(number) < 0)
                    negatives.Add(number);
                else
                {
                    if (int.Parse(number) <= 1000)
                        result += int.Parse(number);
                }
            }
            return result;
        }
        public void checkNegatives(List<string> negatives)
        {
           if (negatives.Count()>0)
               throw new Exception("negatives found : " + string.Join(",", negatives.ToArray()));
        }

    }
  
}
