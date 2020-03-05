using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton
{
    public class SimpleTicketFactory:ITicket
    {
        public Ticket createTicket(string id, int price, TicketType type)
        {
            Ticket ticket = null;
            if (type.Equals(TicketType.General_Admission))
            {
                ticket = new General_Admission_Ticket(id, price);
            }else if (type.Equals(TicketType.Vip))
                {
                    ticket = new VIP_Ticket( id,  price);
                }
                else if(type.Equals(TicketType.Reserved_Seating))
            {
                ticket = new Reserved_Seating_Ticket(id, price);
            }
            return ticket;
        }
    }
}
