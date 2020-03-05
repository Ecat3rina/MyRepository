using System;
using System.Text;
namespace Arrays_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimension;

            Console.WriteLine("Dimension:");
            dimension = int.Parse(Console.ReadLine());

            One_Dim_Arrays.Initialize_PrintArray_IntArray(dimension);
            One_Dim_Arrays.Initialize_PrintArray_StringArray();
            Console.WriteLine();

            Multi_Dim_Arrays.Initialize_PrintArray_Int_Multi_Array(dimension, dimension+2);
            Console.WriteLine();
            Multi_Dim_Arrays.Initialize_PrintArray_String_Multi_Array(dimension);
            Console.WriteLine();

            Strings_Practice.Practice();
            Console.WriteLine();

            String_Builder.Practice();
            Console.WriteLine();

            Split_Join.Practice();
        }
    }
}