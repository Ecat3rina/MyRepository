using System;
using System.Collections.Generic;
using System.Text;

namespace Event
{   
    public class Chef
    {
        public delegate void FoodToCookHandler(FoodCookedEventArgs obj);
        public event FoodToCookHandler OnProcess;
        
        public virtual void CookFood( string foodType)
        {
            OnProcess += Program.OnRequest;
            OnProcess?.Invoke(new FoodCookedEventArgs(foodType));
            OnProcess -= Program.OnRequest;
            OnFoodCooked( foodType);

        }
        public virtual void OnFoodCooked( string foodType)
        {
            OnProcess+=Program.RequestCompleted;            
            OnProcess?.Invoke(new FoodCookedEventArgs(foodType) );
            OnProcess -= Program.RequestCompleted;
        }
    }
}
