using System;
using System.Collections.Generic;
using System.Text;

namespace AdvancedLINQ
{
    public class Country
    {
        public IEnumerable<Nationality> Nationalities { get; set; }
        public string Name { get; set; }
        public int Area { get; set; }
        public int Population { get; set; }
    }
}
