using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    class One_Dim_Arrays
    {
        public static void Initialize_PrintArray_IntArray(int dim)
        {
            Random rand = new Random();
            int[] A = new int[dim];
            for (int i = 0; i < dim; i++)
                A[i] = rand.Next(10);
            Console.WriteLine("The length of the array is {0}", A.Length);
            for (int i = 0; i < dim; i++)
                Console.WriteLine("On index {0} is {1} element", i, A[i]);
        
            Console.WriteLine("\nSorted array ");
            Array.Sort(A,0,dim);
            for (int i = 0; i < dim; i++)
                Console.Write("{0} ", A[i]);
            Console.WriteLine();
        }
        public static void Initialize_PrintArray_StringArray()
        {
            string[] S = new string[3];
            S[0] = "It's ";
            S[1] = "a ";
            S[2] = "program!";
            foreach (string s in S)
                Console.Write(s);
            Console.WriteLine("\nGetValue(1)-> {0} ",S.GetValue(1));
            
            Console.WriteLine("Reversed string array ");
            Array.Reverse(S, 0, S.Length);
            for (int i = 0; i < S.Length; i++)
                Console.Write("{0} ", S [i]);
        }
    }
}
