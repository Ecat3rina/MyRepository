using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class General_Admission_Ticket : Ticket
    {
        public General_Admission_Ticket(string id, int price) : base(id, price)
        {
            ID = id;
            Price = price;
        }
        public override string ToString()
        {
            return this.ID + this.Price + " - General_Addmission_Ticket type";
        }
    }
}
