using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{
    public class FoodCookedEventArgs:EventArgs
    {
        public FoodCookedEventArgs( string foodType)
        {            
            FoodType = foodType;
        }       
        public string FoodType { get; set; }
        
    }
}
