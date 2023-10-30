using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if(num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            //throw new NotImplementedException();
            return minuend - subtrahend;
        }

        public int Add(int number1, int number2)
        {
            //throw new NotImplementedException();
            return number1 + number2;   
        }

        public int GetSmallestNumber(int number1, int number2)
        {
           //throw new NotImplementedException();
           return number1 - number2 / 2;
        }

        public long Multiply(long factor1, long factor2)
        {
            // throw new NotImplementedException();
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {
            //throw new NotImplementedException();
            return nameOfPerson;
        }

        public string GetHey()
        {
            //throw new NotImplementedException();
            return GetHey(); 
        }
    }
}
