using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedLINQ
{
    public class Country
    {
        public IEnumerable<Ethnic_Group> Ethnic_Groups { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        public Continent Which_Continent { get; set; }
        
    }
}
