using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class Ticket:ITicket
    {
        public Ticket(string id, int price)
        {
            ID = id;
            Price = price;
        }

        public string ID { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return Price + "   " + ID;
        }
    }
}
