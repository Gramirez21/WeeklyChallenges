using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if (startNumber == 0)
            {
                startNumber++;
            }
            int x = startNumber + 1;
            do
            {
                
                if(x % n == 0)
                {
                    break;
                }
                else
                {
                    x++;
                }


            } while (x % n != 0);

            return x;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            foreach (Business item in businesses)
            {
                if (item.TotalRevenue == 0)
                {
                    item.Name = "CLOSED";
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {

            if (numbers == null || numbers.Length <= 0)
                return false;
            if(numbers.Length <= 1)
            {
                return true;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
                    
            }

            return true;






        }





























        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers != null)
            {


                List<int> result = new List<int>();
                int x = 1;
                for (int i = 0; x < numbers.Length; i++)
                {
                    if (numbers[i] % 2 == 0)
                    {
                        result.Add(numbers[x]);

                    }

                    x++;
                }

                return result.Sum();
            }
            else
            {
                return 0;
            }
        }


        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            StringBuilder sentenceBuilder = new StringBuilder();

            foreach (string word in words)
            {
                // Trim the word to remove leading and trailing spaces
                string trimmedWord = word.Trim();

                // Skip empty strings
                if (string.IsNullOrEmpty(trimmedWord))
                {
                    continue;
                }

                // Append the trimmed word to the sentence with a space separator
                if (sentenceBuilder.Length > 0)
                {
                    sentenceBuilder.Append(" ");
                }
                sentenceBuilder.Append(trimmedWord);
            }

            // Ensure that the sentence ends with a period
            if (sentenceBuilder.Length > 0)
            {
                sentenceBuilder.Append(".");
            }

            return sentenceBuilder.ToString();

        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            List<double> result = new List<double>();
            if (elements != null)
            {

               
                for (int i = 3; i < elements.Count;)
                {
                    result.Add(elements[i]);
                    i++;
                    i++;
                    i++;
                    i++;
                }

            }
            else
            {
                return new double[0];
            }
            return result.ToArray();    
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            HashSet<int> complements = new HashSet<int>();

            foreach (int num in nums)
            {
                int complement = targetNumber - num;
                if (complements.Contains(num))
                {
                    return true;
                }
                complements.Add(complement);
            }

            return false;

        }
    }
}
