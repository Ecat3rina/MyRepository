using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new[]
            {
                new Country {Name = "Moldova", Area = 200, Population = 100},
                new Country {Name = "China", Area = 2005, Population = 1001},
            };
            Console.WriteLine("-------Select--------");
            IEnumerable<string> name_of_countries = countries.Select(x => x.Name + " has " + x.Population + " people");
            foreach (var n in name_of_countries)
                Console.WriteLine(n);

            var countries1 = new List<Country>()
            {
            new Country()
            {
            Name ="Russia",
            Ethnic_Groups = new List<Ethnic_Group>(){ new Ethnic_Group() { Ethinc_Group_Name="russian"}, new Ethnic_Group() { Ethinc_Group_Name="tatar"},new Ethnic_Group() { Ethinc_Group_Name="ukranian"}}
        },
        new Country()
        {
            Name = "USA",
            Ethnic_Groups = new List<Ethnic_Group>() { new Ethnic_Group() { Ethinc_Group_Name = "latino" }, new Ethnic_Group() { Ethinc_Group_Name = "american" } }
        }
    };
            Console.WriteLine("-------SelectMany--------");
            var allethnicgroups = countries1.SelectMany(x => x.Ethnic_Groups, (parent, child) => new { parent.Name, child.Ethinc_Group_Name });
            foreach (var e in allethnicgroups)
                Console.WriteLine(e.Name + " " + e.Ethinc_Group_Name);

            Continent europe = new Continent { Continent_Name = "Europe" };
            Continent asia = new Continent { Continent_Name = "Asia" };
            Country moldova = new Country { Name = "Moldova", Area = 200, Population = 100, Which_Continent = europe };
            Country india = new Country { Name = "India", Area = 2003, Population = 12020, Which_Continent = asia };
            IList<Continent> continents = new List<Continent> { europe, asia };
            IList<Country> countries2 = new List<Country> { moldova, india };
            Console.WriteLine("-------Join--------");
            var join = continents.Join(countries2, continent => continent, country => country.Which_Continent,
                                       (continent, country) => new { ContinentName = continent.Continent_Name, CountryName = country.Name });
            foreach (var j in join)
                Console.WriteLine($"{j.ContinentName}->{j.CountryName}");

            Country romania = new Country { Name = "Romania", Area = 200, Population = 100, Which_Continent = europe };
            Country bangladesh = new Country { Name = "Bangladesh", Area = 2003, Population = 12020, Which_Continent = asia };
            Country cipru = new Country { Name = "Cipru", Area = 2003, Population = 1202 };
            countries2.Add(romania);
            countries2.Add(bangladesh);
            countries2.Add(cipru);
            var groupjoin = continents.GroupJoin(countries2,
                                                 continent => continent,
                                                 country => country.Which_Continent,
                                                 (continent, group_of_countries) => new { result_countries = group_of_countries, result_continent = continent.Continent_Name });

            Console.WriteLine("-------GroupJoin--------");
            foreach (var gj in groupjoin)
            {
                Console.WriteLine($"{ gj.result_continent} :");
                foreach (var country in gj.result_countries)
                    Console.WriteLine($"{ country.Name} ");
            }
            Console.WriteLine("-------Zip--------");
            var zip = countries2.Zip(continents, (country, continent) => country.Name + " is a part of " + continent.Continent_Name);
            foreach (var z in zip)
                Console.WriteLine(z);
            Console.WriteLine("-------OrderByThenBy--------");
            //can add bydescending byascending --Whatever--
            var ordered_countries = countries2.OrderBy(a => a.Area).ThenByDescending(p=>p.Name);
            foreach (var o in ordered_countries)
                Console.WriteLine($"{o.Name}--{o.Area}--{o.Name}");
            Console.WriteLine("-------Reverse--------");
            Console.WriteLine("Before");
            foreach (var c in countries2)
                Console.WriteLine($"{c.Name}--{c.Area}--{c.Population}");
            var reversed = countries2.Reverse();
            Console.WriteLine("After");
            foreach (var r in reversed)
                Console.WriteLine($"{r.Name}--{r.Area}--{r.Population}");
            Console.WriteLine("-------GroupBy Area--------");
            var groupbyArea = countries2.GroupBy(a=>(a.Area));
            foreach (var group in groupbyArea)
            {
                Console.WriteLine("Countries with " + group.Key + " persons:");
                foreach (var user in group)
                    Console.WriteLine("* " + user.Name);
            }

        }
    }
}
