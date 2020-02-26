using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionalLINQ
{
    public class Country
    {
        public string Name{ get; set;}
        public int Population { get; set; }
        public int Area { get; set; }

        public void Show_Details()
        {
            Console.WriteLine($"{Name} has {Population} people and area of {Area}");
        }
    }
}
