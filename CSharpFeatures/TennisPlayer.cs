using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpFeatures
{
    public class TennisPlayer
    {
        public TennisPlayer() { }
        public TennisPlayer(string name, int? rank)
        {
            Name = name;
            ATP_Rank = rank;
        }
        public string Name { get; set; }
        public int? ATP_Rank { get; set; }
        public string Short_Description() => Name +" "+ ATP_Rank+" ATP rank";
        
    }
        
    
}
