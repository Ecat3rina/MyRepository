using System;
using System.Collections.Generic;
using System.Text;

namespace Generics_Collection
{
    public class Ticket:Item
    {
     
        enum Season
        {
            GeneralAdmission,
            VIP,
            ReservedSeating,
            MultiDayPass,
            OneDayPass,
            EarlyBirdDiscount,
            Codeddiscount
        }
        List<Ticket> tickets = new List<Ticket>();
        public void Add_In_ListofTickets(Ticket t)
        {
            tickets.Add(t);
        }
        public void Display_ListofTickets()
        {
            foreach (Ticket i in tickets)
            {
                Console.WriteLine("Name = {0}", i.name);
            }
        }
       
    }
}
