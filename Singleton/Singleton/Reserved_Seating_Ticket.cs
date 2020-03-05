using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Reserved_Seating_Ticket:Ticket
    {   
        public Reserved_Seating_Ticket(string id, int price) : base(id, price )
        {
            ID = id;
            Price = price;
        }
        public override string ToString()
        {
            return this.ID + this.Price + " - Reserved_seating type";
        }
    }
}
