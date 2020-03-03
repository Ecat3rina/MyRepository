using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;


namespace BehavioralPatterns
{
   public class SortedList
   {
       public List<Person> PersonsToSortList { get; set; }
       public ISortStrategy SortStrategy { get; set; }
    

    public List<Person> GetSortedListofPersons()
    {
        return SortStrategy.Sort(this.PersonsToSortList);
    }

   }
}
