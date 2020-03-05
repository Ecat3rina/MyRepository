using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Exceptions
{
    class Methods_Throw_Exceptions
    {
        
       public static void SearchFile()
        {
            if (File.Exists(@"C:\Users\ecaterina.herta\source\repos\Exceptions\Text1.txt"))
            {
                Console.WriteLine("File found!");
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
        public static void GetElementFromArray(int index)
        {            
            int[] int_tab = new int[5];     
            int_tab.Initialize();            
            for (int i = 0; i < int_tab.Length; i++)
                Console.Write("{0} ", int_tab[i]);
           
        }
    }
}
