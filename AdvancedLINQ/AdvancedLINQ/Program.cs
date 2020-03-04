using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace AdvancedLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            Continent europe = new Continent {Continent_Name = "Europe"};
            Continent asia = new Continent {Continent_Name = "Asia"};
            Continent northamerica = new Continent {Continent_Name = "North America"};
            List<Continent> continents = new List<Continent>() {asia, europe,northamerica};
            IEnumerable<Country> countries = new List<Country>()
            {
                
                new Country()
                {
                    Name = "Russia",
                    Area = 40000,
                    Which_Continent = asia,
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
                    Area = 40000,
                    Which_Continent = northamerica,
                    Ethnic_Groups = new List<Ethnic_Group>()
                    {
                        new Ethnic_Group() {Ethinc_Group_Name = "latino"},
                        new Ethnic_Group() {Ethinc_Group_Name = "american"}
                    }
                },
                new Country()
                {
                    Name = "Moldova",
                    Area = 2000,
                    Which_Continent = europe,
                    Ethnic_Groups = new List<Ethnic_Group>()
                    {
                        new Ethnic_Group() {Ethinc_Group_Name = "gagauzian"},
                        new Ethnic_Group() {Ethinc_Group_Name = "romanian"},
                        new Ethnic_Group() {Ethinc_Group_Name = "moldavian"}
                    }
                },
                new Country()
                {
                    Name = "China",
                    Area = 30000,
                    Which_Continent = asia,
                    Ethnic_Groups = new List<Ethnic_Group>()
                    {
                        new Ethnic_Group() {Ethinc_Group_Name = "chinese"},
                        new Ethnic_Group() {Ethinc_Group_Name = "japanese"},
                        new Ethnic_Group() {Ethinc_Group_Name = "malaysian"}
                    }
                }

            };

            var where = countries.Select(x => new {x.Name, x.Area,x.Ethnic_Groups}).Distinct().Where(x=>x.Ethnic_Groups.Count()==2);
            foreach (var c in where)
                Console.WriteLine(c.Name);
            Console.WriteLine("-------Select--------");
            IEnumerable<string> name_of_countries = countries.Select(x => x.Name);
            foreach (var n in name_of_countries)
                Console.WriteLine(n);


            Console.WriteLine("-------SelectMany--------");
            var ethnicgroups = countries
                .SelectMany(x => x.Ethnic_Groups, (parent, child) => new {parent.Name, child.Ethinc_Group_Name});

            foreach (var e in ethnicgroups)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("-------Join--------");
            var join = continents.Join(countries,
                continent => continent,
                country => country.Which_Continent,
                (continent, country) => new
                {
                    ContinentName = continent.Continent_Name,
                    CountryName = country.Name
                });
            foreach (var j in join)
                Console.WriteLine($"{j.ContinentName}->{j.CountryName}");
            Console.WriteLine("-------GroupJoin--------");
            var groupjoin = continents.GroupJoin(countries,
                continent => continent,
                country => country.Which_Continent,
                (continent, group_of_countries) => new
                {
                    ContinentName = continent.Continent_Name,
                    result_countries=group_of_countries
                });
            foreach (var gj in groupjoin)
            {
                Console.WriteLine(gj.ContinentName+":");
                foreach (var g in gj.result_countries)
                {
                    Console.WriteLine(g.Name);
                }
            }
            Console.WriteLine("-------Zip--------");
            var zip = countries.Zip(continents,(country, continent)=>country.Name+" is a part of "+continent.Continent_Name);
            foreach (var z in zip)
                Console.WriteLine(z);
            Console.WriteLine("-------OrderBy--------");
            var order = countries.OrderBy(x=>x.Area).ThenByDescending(x=>x.Name);
            foreach (var o in order)
                Console.WriteLine(o.Name+" "+o.Area);
            Console.WriteLine("-------GroupBy--------");
            var groupby = countries.GroupBy(x => x.Area);
            foreach (var gb in groupby)
            {
                Console.WriteLine($"Area of {gb.Key} have :");
                foreach (var c in gb )
                {
                    Console.WriteLine(c.Name);
                }
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
            Console.WriteLine("Dictionary");
            var new_dictionary = countries.ToDictionary(e => e.Name, b => b.Area);
            foreach (var item in new_dictionary)
                Console.WriteLine(item.Value + "-" + item.Key);
            var tolookup = countries.ToLookup(a => a.Area); 
            foreach (var item in tolookup[40000])
                Console.WriteLine(item.Name);

            var asenum = t1.AsEnumerable(); 
            foreach (var element in asenum) 
            {
                Console.WriteLine(element);
            }

            int[] t = new int[] { };
            int query = Queryable.Sum(t.AsQueryable());
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
