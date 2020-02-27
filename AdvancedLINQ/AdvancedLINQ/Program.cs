using System;
using System.Collections;
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
                    Name = "Russia",
                    Ethnic_Groups = new List<Ethnic_Group>()
                    {
                        new Ethnic_Group() {Ethinc_Group_Name = "russian"},
                        new Ethnic_Group() {Ethinc_Group_Name = "tatar"},
                        new Ethnic_Group() {Ethinc_Group_Name = "ukranian"}
                    }
                },
                new Country()
                {
                    Name = "USA",
                    Ethnic_Groups = new List<Ethnic_Group>()
                    {
                        new Ethnic_Group() {Ethinc_Group_Name = "latino"},
                        new Ethnic_Group() {Ethinc_Group_Name = "american"}
                    }
                }
            };
            Console.WriteLine("-------SelectMany--------");
            var allethnicgroups = countries1.SelectMany(x => x.Ethnic_Groups,
                (parent, child) => new {parent.Name, child.Ethinc_Group_Name});
            foreach (var e in allethnicgroups)
                Console.WriteLine(e.Name + " " + e.Ethinc_Group_Name);

            Continent europe = new Continent {Continent_Name = "Europe"};
            Continent asia = new Continent {Continent_Name = "Asia"};
            Country moldova = new Country {Name = "Moldova", Area = 200, Population = 100, Which_Continent = europe};
            Country india = new Country {Name = "India", Area = 2003, Population = 12020, Which_Continent = asia};
            IList<Continent> continents = new List<Continent> {europe, asia};
            IList<Country> countries2 = new List<Country> {moldova, india};
            Console.WriteLine("-------Join--------");
            var join = continents.Join(countries2, continent => continent, country => country.Which_Continent,
                (continent, country) => new {ContinentName = continent.Continent_Name, CountryName = country.Name});
            foreach (var j in join)
                Console.WriteLine($"{j.ContinentName}->{j.CountryName}");

            Country romania = new Country {Name = "Romania", Area = 200, Population = 100, Which_Continent = europe};
            Country bangladesh = new Country
                {Name = "Bangladesh", Area = 2003, Population = 12020, Which_Continent = asia};
            Country cipru = new Country {Name = "Cipru", Area = 2003, Population = 1202};
            countries2.Add(romania);
            countries2.Add(bangladesh);
            countries2.Add(cipru);
            var groupjoin = continents.GroupJoin(countries2,
                continent => continent,
                country => country.Which_Continent,
                (continent, group_of_countries) => new
                    {result_countries = group_of_countries, result_continent = continent.Continent_Name});

            Console.WriteLine("-------GroupJoin--------");
            foreach (var gj in groupjoin)
            {
                Console.WriteLine($"{gj.result_continent} :");
                foreach (var country in gj.result_countries)
                    Console.WriteLine($"{country.Name} ");
            }

            Console.WriteLine("-------Zip--------");
            var zip = countries2.Zip(continents,
                (country, continent) => country.Name + " is a part of " + continent.Continent_Name);
            foreach (var z in zip)
                Console.WriteLine(z);
            Console.WriteLine("-------OrderByThenBy--------");
            //can add bydescending byascending --Whatever--
            var ordered_countries = countries2.OrderBy(a => a.Area).ThenByDescending(p => p.Name);
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
            var groupbyArea = countries2.GroupBy(a => (a.Area));
            foreach (var group in groupbyArea)
            {
                Console.WriteLine("Countries with " + group.Key + " persons:");
                foreach (var user in group)
                    Console.WriteLine("* " + user.Name);
            }

            Console.WriteLine("------------Set Operators----------");
            int[] t1 = {2, 4, 7, 1, 2, 1};
            int[] t2 = {2, 2, 4, 5, 4, 1};
            var result = t1.Concat(t2);
            Console.WriteLine("Concat");
            foreach (int i in result)
                Console.WriteLine(i + " ");
            Console.WriteLine("Union");
            result = t1.Union(t2);
            foreach (int i in result)
                Console.WriteLine(i + " ");
            Console.WriteLine("Intersect");
            result = t1.Intersect(t2);
            foreach (int i in result)
                Console.WriteLine(i + " ");
            Console.WriteLine("Except");
            result = t1.Except(t2);
            foreach (int i in result)
                Console.WriteLine(i + " ");
            Console.WriteLine("------------Conversion Methods----------");
            ArrayList list = new ArrayList(4);
            list.Add("books");
            list.Add(7);
            list.Add("sport");
            list.Add(2.5);
            var list1 = list.OfType<string>();
            foreach (string item in list1)
                Console.WriteLine(item);
            ArrayList ArraylistOfInts = new ArrayList(4);
            ArraylistOfInts.Add(1);
            ArraylistOfInts.Add(7);
            ArraylistOfInts.Add(4);
            ArraylistOfInts.Add(5);
            var list2 = ArraylistOfInts.Cast<int>();
            foreach (var item in list2)
                Console.WriteLine(item);
            var new_array = ArraylistOfInts.ToArray();
            for (int i = 0; i < new_array.Length; i++)
                Console.WriteLine(new_array[i]);
            var new_list = t2.ToList();
            foreach (var item in new_list)
                Console.Write(item + "-");
            Console.WriteLine();
            var new_dictionary = countries.ToDictionary(e => e.Name, b => b.Area);
            foreach (var item in new_dictionary)
                Console.WriteLine(item.Value + "-" + item.Key);
            var tolookup = countries2.ToLookup(a => a.Population);
            foreach (var item in tolookup[100])
                Console.WriteLine(item.Name + "-" + item.Population);

            var asenum = t1.AsEnumerable();
            foreach (var element in asenum)
            {
                Console.WriteLine(element);
            }

            int[] t = new int[] { };
            int query = Queryable.Sum(t2.AsQueryable());
            Console.WriteLine("Sum: " + query);
            Console.WriteLine("First element is " + t2.First(i => i % 4 == 0));
            Console.WriteLine("First element is " + t.FirstOrDefault(i => i % 4 == 0));
            Console.WriteLine("Last element is " + t2.First(i => i % 4 == 0));
            Console.WriteLine("Last element is " + t2.FirstOrDefault(i => i % 4 == 0));
            Console.WriteLine("Single element is " + t1.Single(i => i % 4 == 0)); //for t2 ERROR
            Console.WriteLine("ElementAt element is " + t2.ElementAt(5));

            List<int> li = new List<int>();
            Console.WriteLine("DefaultEmpty element is " + t.DefaultIfEmpty());
            Console.WriteLine("Long is " + t2.Count());
            Console.WriteLine("Min element is " + t2.Min());
            Console.WriteLine("Max element is " + t2.Max());
            Console.WriteLine("Sum element is " + t2.Sum());
            Console.WriteLine("Average element is " + t2.Average());
            int max =
                t2.Aggregate(t2[0],
                    (maxim, next) =>
                        next > maxim ? next : maxim,
                    max_nr => max_nr);
            Console.WriteLine("Max aggregate element is " + max);
            Console.WriteLine("t2 contains 1 " + t2.Contains(1));
            Console.WriteLine("t2 contains 100 " + t2.Contains(100));
            Console.WriteLine("t2 any contains 4 " + t2.Any(e => e > 0));
            Console.WriteLine("t2 all contains 1 " + t2.All(e => e == 2));
            int[] t3 = {2, 2};
            int[] t4 = {2, 2};
            Console.WriteLine("t2 has sequence 4,5 " + t4.SequenceEqual(t3));
            List<int> ints = Enumerable.Empty<int>().ToList();
            ints.Add(2);
            foreach (var i in ints)
            {
                Console.WriteLine(i);
            }

            var rep = Enumerable.Repeat(10, 3);
            foreach (int res in rep)
            {
                Console.WriteLine(res);
            }

            IEnumerable<int> numberSequence = Enumerable.Range(10, 5);
            var closure = Modify(5);
            Console.WriteLine(closure(6));
            Console.WriteLine(closure(7));

        }

        public static Func<int, string> Modify(int y)
        {
            var cnt = 0;
            return (x) =>
            {
                cnt++;
                return (x * y + cnt).ToString();
            };
        }
    }

}
