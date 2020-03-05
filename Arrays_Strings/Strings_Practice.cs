using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    class Strings_Practice
    {
        public static void Practice()
        {
            string[] string_array = { "This is a ", "long ", "string ", "array" };
         
            string s = String.Concat(string_array);
            Console.WriteLine(s);
            string new_s = s.Replace("long", "short");
            Console.WriteLine(new_s);
            string up_s = new_s.ToUpper();
            Console.WriteLine(up_s.PadLeft(100, '*'));
            Console.WriteLine(up_s.PadRight(100, '*'));
            string remove_s = up_s.Remove(10, 6);
            Console.WriteLine(remove_s);
            string verbatim1 = @"S:\Internship2002\1. C#\6. Array, String";
            Console.WriteLine(verbatim1);
            string verbatim2 = @"Looooooo
ooo
ooo
ooo
ong
string";
            Console.WriteLine(verbatim2);
            
        }
    }
}
