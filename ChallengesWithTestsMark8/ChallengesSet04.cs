using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int i = 0;
            foreach (int number in numbers)
            {
               
                if (number % 2  == 0)
                {
                    i += number;
                }
                else
                {
                    i -= number;
                }

                
            }
            return i;
           
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List <string> numbers = new List <string> ();   
            numbers.Add(str1);
            numbers.Add(str2);  
            numbers.Add(str3);
            numbers.Add(str4);

            var x = numbers.Min(x => x.Length);

            

            return x;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List <int> i = new List<int> ();
            i.Add (number1);    
            i.Add (number2);
            i.Add (number3);
            i.Add (number4);

            int x = i.Min();
            return x;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            bool solution = false;

            if (sideLength1 + sideLength2 > sideLength3 && sideLength3 + sideLength2 > sideLength1 && sideLength1 + sideLength3 > sideLength2)
            {
                solution = true;
            }
            else
            {
                solution = false;
            }

            return solution;
        }
  
        public bool IsStringANumber(string input)
        {
           
            bool isNumber = false;

            if (input == null)
            {
                return isNumber;
            }
            int decimalCount = input.Count(x => x == '.');
            if (decimalCount > 1)
            {
                return isNumber;
            }
                        

            for (int i = 0; i < input.Length; i++)
            {               


                if (char.IsDigit(input[i]) || char.IsNumber(input[i]) || input[i] =='.' || input.StartsWith('-'))
                {
                    isNumber = true;
                    
                }
                else
                {
                    isNumber = false;
                    break;
                }              
                
            }
            

            return isNumber;   
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int x = 0;
            int y = 0;
            bool solution = false;
            for (int i = 0; i < objs.Length; i++)
            {
                if (objs[i] == null)
                {
                    x++;
                }
                else
                {

                    y++;
                }
                
            }
            if (x > y)
            {
                solution = true;
            }
            return solution;
        }

        public double AverageEvens(int[] numbers)
        {
            


            if (numbers == null)
            {
                return 0;
            }

            

            List <int> list = new List <int>();
          
            for (int i = 0; i < numbers.Length; i++) 
            {
               if (numbers[i] % 2 == 0 && numbers != null)
                {
                    list.Add(numbers[i]);

                   
                }
              
               

               
            }




            if(list.Count != 0)
            {
                return list.Average();
            }
            else { return 0; }



        }

        public int Factorial(int number)
        {

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }

            int x = 1;
            for (int i = 1; i <= number; i++)
            {
               
                
                if (i <= number)
                {
                    x = i * x;
                }
            }

            return x;
        }
    }
}
