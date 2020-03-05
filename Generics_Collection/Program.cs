using System;
using System.Collections.Generic;

namespace Generics_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Generic_Collection_Class<int> intArray = new Generic_Collection_Class<int>(4);
            int i;
            for (i = 0; i < 4; i++)
            {
                intArray.SetItem(i, i);
            }

            for (i = 0; i < 4; i++)
            {
                Console.Write(intArray.GetItem(i) + " ");
            }
            Console.WriteLine();
            int element1 = intArray.GetItem(0), element2 = intArray.GetItem(1); ;
            intArray.Swap<int>(ref element1, ref element2);
            intArray.SetItem(0, element1);
            intArray.SetItem(1, element2);
            for (i = 0; i < 4; i++)
            {
                Console.Write(intArray.GetItem(i) + " ");
            }
            Console.WriteLine();

            Repository<Product> generic_repository = new Repository<Product>();
            generic_repository.Add(new Product { name="first", id=1});
            generic_repository.Add(new Product { name = "second", id = 2 });
            generic_repository.Add(new Product { name = "third", id = 3 });
            generic_repository.Add(new Product { name = "fourth", id = 4 });

            Item new_items = new Item();
            new_items.Add_In_Dictionary("key1","item1");
            new_items.Add_In_Dictionary("key2", "item2");
            new_items.Display_Dictionary();
            Console.WriteLine();
            Ticket new_tickets = new Ticket();
            new_tickets.Add_In_ListofTickets(new Ticket { name = "ticket1" });
            new_tickets.Add_In_ListofTickets(new Ticket { name = "ticket2" });
            new_tickets.Add_In_ListofTickets(new Ticket { name = "ticket3" });
            new_tickets.Display_ListofTickets();

            var t1 = new Ticket{name="ticket1", ItemId="1" };
            var t2 = new Ticket{ name = "ticket1", ItemId = "3" };
            TicketComparer compare_ticket = new TicketComparer();
            Console.WriteLine(compare_ticket.Equals(t1, t2));
            
            IEnumerable<Item> items = new List<Ticket>(100);
            //foreach ( var i in items)
            //    Console.WriteLine(i);
        }
    }
}
