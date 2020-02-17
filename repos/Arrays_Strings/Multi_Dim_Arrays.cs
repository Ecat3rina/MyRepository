using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    class Multi_Dim_Arrays
    {
        public static void Initialize_PrintArray_Int_Multi_Array(int dim1, int dim2)
        {
            int[,] M = new int[dim1, dim2];
            for (int i = 0; i < dim1; i++)
                for (int k = 0; k < dim2; k++)
                    if (i == k)
                        M[i, k] = 1;
            for (int i = 0; i < dim1; i++)
            {
                for (int k = 0; k < dim2; k++)
                {
                    Console.Write(M[i, k] + "\t");
                }
                Console.WriteLine();
            }
        }
        public static void Initialize_PrintArray_String_Multi_Array(int dim1)
        {
            Random rand = new Random();
            int dim2 = rand.Next(1, 5);
            Console.WriteLine("{0}*{1} multi dimensional array:", dim1, dim2);
            string[,] M = new string[dim1, dim2];
            for (int i = 0; i < dim1; i++)
                for (int k = 0; k < dim2; k++)
                    M[i, k] = i.ToString() + ',' + k.ToString() + "\t";
            for (int i = 0; i < dim1; i++)
            {
                for (int k = 0; k < dim2; k++)
                {
                    Console.Write(M[i, k] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
