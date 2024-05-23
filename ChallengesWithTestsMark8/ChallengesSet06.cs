using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)
        {
            bool solution = false;
            if (words != null)
            {
                string[] array = words.ToArray();
                
                for (int i = 0; i < array.Length; i++)
                {
                    var x = array[i];
                    if(x == null)
                    {
                        continue;

                    }
                    if (x == word)
                    {
                        solution = true;
                        break;
                    }
                    else if (x.ToLower() == word.ToLower() && ignoreCase == true)
                    {
                        solution = true;
                        break;
                    }
                }
            }


            else
            {
                solution = false;
            }
            return solution;
            
                
            
        }

        public bool IsPrimeNumber(int num)
        {
            bool solution = false;
            if(num == 2|| num == 3)
            {
                return true;
               
            }

            if (num == 0 || num == 1)
            {
                solution = false;
            }
            for (int i = 2; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    solution = false;
                    break;
                }
                else
                {
                    solution = true;
                }
            }

            return solution;
            
        }

        public int IndexOfLastUniqueLetter(string str)
        {
            if (string.IsNullOrEmpty(str))
                return -1;

            Dictionary<char, int> charCount = new Dictionary<char, int>();

            // Count occurrences of each character
            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                {
                    charCount[c]++;
                }
                else
                {
                    charCount[c] = 1;
                }
            }

            // Find the last unique character
            int lastIndex = -1;
            for (int i = 0; i < str.Length; i++)
            {
                if (charCount[str[i]] == 1)
                {
                    lastIndex = i;
                }
            }

            return lastIndex;
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
                return 0;

            int maxCount = 0;
            int currentCount = 1; // Start from 1 since there's at least one element in the array.

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                    maxCount = Math.Max(maxCount, currentCount);
                }
                else
                {
                    currentCount = 1; // Reset count for a new sequence.
                }
            }

            return maxCount;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)
        {
            if (elements == null || elements.Count == 0 || n <= 0)
                return new double[0]; // Return an empty array if the input array is null, empty, or if the stride is non-positive.

            List<double> filteredList = new List<double>();

            for (int i = n - 1; i < elements.Count; i += n)
            {
                filteredList.Add(elements[i]);
            }

            return filteredList.ToArray();
        }
    }
}
