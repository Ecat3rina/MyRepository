using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BehavioralPatterns
{
    class SortByName:ISortStrategy
    {
        public List<Person> Sort(List<Person> list)
        {
             return list.OrderBy(x=>x.Name).ToList();
             //Console.WriteLine("List by name sorted!");
        }
    }
}
