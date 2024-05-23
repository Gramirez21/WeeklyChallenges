using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            return char.IsLetter(c);
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            return number % 2 == 0;
        }

        public bool IsNumberOdd(int num)
        {
            return num % 2 != 0;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() < 1)
            {
                return 0;
            }
            else
            {
                double i = numbers.Min(x => x);
                double j = numbers.Max(x => x);
                return i + j;
            }
        }


        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            else
            {
                return str2.Length;
            }
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Sum();
            }

        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            else
            {
                return numbers.Where(x => x % 2 == 0).Sum();
            }





        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            int i = numbers.Sum();

            if (i % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public long CountOfPositiveOddsBelowNumber(long number)
        {

            long result = 0;
            for (long i = number; i > 0; i--)
            {


                if (i % 2 != 0 && i != number)
                {
                    result++;


                }
                                
            }

            number = result;

            if (number > 0)
            {
                return number;
            }
            else { return 0; }
        }
    }
}
