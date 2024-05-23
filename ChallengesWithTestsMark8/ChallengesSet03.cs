using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
        {

            if (numbers == null)
            {
                return false;
            }
            if (numbers.Sum() % 2 != 0  )
            {
                return true;
            }
            
            else
            {
                return false;
            }
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            bool upper = false;
            bool lower = false;
            bool ints = false;

            for (int i = 0; i < password.Length; i++)
            {

                
                if (char.IsUpper(password[i]))
                {
                    upper = true;
                }
                if (char.IsLower(password[i]))
                {
                    lower = true;

                }
                if (char.IsNumber(password[i]))
                {
                    ints = true;
                }
            }

            if(upper == true && lower == true && ints == true)
            {
                return true; 
            }
            else
            {
                return false;
            }

        }

        public char GetFirstLetterOfString(string val)
        {
            val.ToArray();
            return val[0];

        }

        public char GetLastLetterOfString(string val)
        {
            val.ToArray();
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            else
            {
                return dividend / divisor;
            }
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums.Last() - nums[0];
            
        }

        public int[] GetOddsBelow100()
        {

            List<int> nums = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 != 0)
                {
                    nums.Add(i);
                }

              
            }

            return nums.ToArray();


            

            



        }

        public  void ChangeAllElementsToUppercase(string[] words)
        {

            
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();
            }

        }
    }
}
