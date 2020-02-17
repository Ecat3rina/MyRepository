using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class Methods_Throw_Exceptions
    {
        public static double Exponentiation(int a, int b)
        {
            if (a == 0 && b == 0)
                throw new ArithmeticException("Not able to calculate zero to power zero!");
            return Math.Pow(a,b);
        }
        public static void GetElementFromArray(int index)
        {
            Random rand = new Random();
            int[] int_tab = new int[rand.Next(0, 5)];
            int_tab.Initialize();
            Console.WriteLine("Length of array: {0}", int_tab.Length);
            for (int i = 0; i < int_tab.Length; i++)
                Console.Write("{0} ", int_tab[i]);
            if (index > int_tab.Length - 1)
                throw new IndexOutOfRangeException();
            Console.Write("\nOn index {0} is the {1} element ", index, int_tab[index]);
        }
    }
}
