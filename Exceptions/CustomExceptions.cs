using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class CustomExceptions
    {
        public static double Exponentiation(int a, int b)
         {
             if (a == 0 && b == 0)
                 throw new MyFirstException("Not able to calculate zero to power zero!");
            return Math.Pow(a,b);
         }

        public static void Get_Year(int year) 
        {
            int currentYear = DateTime.Now.Year;
            if(year!=currentYear)
                throw new MySecondException("Wrong year!");
            Console.WriteLine("2020-Correct!");
        }
        public static void  Get_Name(char letter, int position, int j_position, string name)
        {            
                if (Char.IsDigit(letter))
                    throw new DigitException();
                if (Char.IsWhiteSpace(letter))
                    throw new WhiteSpaceException();
                if(Char.IsLower(letter)&&(position==0))
                    throw new FirstLowerException();
                 if (j_position<name.Length)
                    throw new LengthException();            
        }
    }
}
