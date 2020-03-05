using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class TicketStore { 
        SimpleTicketFactory factory;
        public TicketStore(SimpleTicketFactory factory)
        {
            this.factory = factory;
        }
        public Ticket orderTicket(string id, int price,TicketType type)
        {
            Ticket ticket;
            ticket = factory.createTicket(id, price, type);
            return ticket;
        }
    }
}
