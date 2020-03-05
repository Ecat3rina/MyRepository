using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    class String_Builder
    {
        public static void Practice()
        {
            StringBuilder str = new StringBuilder();
            str.Capacity = 10;
            Console.WriteLine(str);
            str.Append("It's a new string ");
            Console.WriteLine("Length and Capacity of this StringBuilder: {0} and {1}", str.Length,str.Capacity);
            str.Append(" we added some new data: ");
            Console.WriteLine(str);
            Console.WriteLine("Capacity of this StringBuilder: {0}", str.Capacity);
            str.Replace("new", "old");
            Console.WriteLine(str);

        }
    }
}
