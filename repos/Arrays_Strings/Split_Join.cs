using System;
using System.Collections.Generic;
using System.Text;

namespace Arrays_Strings
{
    class Split_Join
    {
        public static void Practice()
        {
            string text_to_split = ",one,two,three";
            string[] splitted_text = text_to_split.Split(',');
            for (int i = 0; i < splitted_text.Length; i++)
                Console.WriteLine(splitted_text[i]);

            string[] text_to_join = new string[splitted_text.Length];
            Array.Copy(splitted_text,text_to_join, splitted_text.Length);
           // char[] c = new char[] {'a','b','d' };
            String.Join("+", text_to_join);
            Console.WriteLine(string.Join("+", text_to_join));
            
        }
    }

}
