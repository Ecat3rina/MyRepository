using System;
using System.Linq;


namespace FunctionalLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new Country[]
            {
                new Country {Name = "Moldova", Area = 200, Population = 100},
                new Country {Name = "China", Area = 2005, Population = 1001},
                new Country {Name = "India", Area = 2002, Population = 10011},
                new Country {Name = "Italia", Area = 20021, Population = 10}
            };
            Console.WriteLine("---------By Population--------");
            DescendingBubbleSorter.Sort(countries, DescendingBubbleSorter.IsASmallerThanB_Population);
            for (int i = 0; i < countries.Length; i++)
                countries[i].Show_Details();
            Console.WriteLine("------------By Area-------------");
            DescendingBubbleSorter.Sort(countries, DescendingBubbleSorter.IsASmallerThanB_Area);
            for (int i = 0; i < countries.Length; i++)
                countries[i].Show_Details();


            var new_countries = new Country[]
            {
                new Country {Name = "Moldova", Area = 200, Population = 100},
                new Country {Name = "China", Area = 2005, Population = 1001}
            };
            Console.WriteLine("-----------Using Anonymous Function by Area+Population-------------");
            DescendingBubbleSorter.Sort(new_countries, delegate(object a, object b)
            {
                 return ((Country) a).Population+((Country)a).Area<((Country) b).Population+((Country) a).Area;
            });
            for (int i = 0; i < new_countries.Length; i++)
                new_countries[i].Show_Details();
            Console.WriteLine("---------------Using Lambda Expression by Area+Population-------------");
            DescendingBubbleSorter.Sort(new_countries, (a, b)=>
                (((Country)a).Population + ((Country)a).Area < ((Country)b).Population + ((Country)a).Area));
                for (int i = 0; i < new_countries.Length; i++)
                new_countries[i].Show_Details();
                var c = new Country() { Name = "France",Area=3456, Population = 3252};
                Console.WriteLine((c.Name).Modify_Name());
                (c.Area).Determine_Type(c.Name);

                var special_countries = countries
                    .Where(s => s.Population> 1000)
                        .Select(p=>p.Name+"  has "+p.Population+" people");
             
                    foreach (var VARIABLE in special_countries)
                    {
                        Console.WriteLine(VARIABLE);
                    }
        }

    }
    
}

