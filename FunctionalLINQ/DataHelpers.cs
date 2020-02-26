using System;
using System.Collections.Generic;
using System.Text;
using FunctionalLINQ;

namespace FunctionalLINQ
{
    public static class DataHelpers
    {
        public static string Modify_Name(this string name)
        {
            return "Name of country is " + name;
        }
        public static void Determine_Type(this int area,string name)
        {
            if (area>100)
                Console.WriteLine(Modify_Name(name)+".It's a big country.");
            else
            {
                Console.WriteLine(Modify_Name(name) + ".It's a small country.");
            }
        }
    }
}
