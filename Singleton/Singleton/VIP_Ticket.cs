using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class VIP_Ticket : Ticket
    {        
        public VIP_Ticket(string id, int price) : base( id, price)
        {
            ID = id;
            Price = price;
        }
        public override string ToString()
        {
            return this.ID+this.Price+" - VIP type";
        }

    }
}
