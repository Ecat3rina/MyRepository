using System;
using System.Collections.Generic;
using System.Text;

namespace BehavioralPatterns
{
   public interface ISortStrategy
   {
       List<Person> Sort(List<Person> list);
   }
}
