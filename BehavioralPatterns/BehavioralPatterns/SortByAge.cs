using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns
{ class SortByAge:ISortStrategy
    {
        public List<Person> Sort(List<Person> list)
        {
            return  list.OrderBy(x => x.Age).ToList();
            // Console.WriteLine("List by Age sorted!");
        }
    }
}
