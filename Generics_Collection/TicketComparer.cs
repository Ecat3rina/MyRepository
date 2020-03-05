using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Collection
{
    public class TicketComparer:IEqualityComparer<Ticket>
    {
        public bool Equals(Ticket x, Ticket y)
        {
            return x.name == y.name && x.ItemId == y.ItemId;
        }
    }
}
