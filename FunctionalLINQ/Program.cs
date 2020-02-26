using System;

namespace FunctionalLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var countries = new Country[]
            {
            new Country{ Name="Moldova", Area=200, Population=100},
            new Country{ Name="China", Area=2005, Population=1001},
            new Country{ Name="India", Area=2002, Population=10011}
            };
            Console.WriteLine("By Population");
            DescendingBubbleSorter.Sort(countries, DescendingBubbleSorter.IsASmallerThanB_Population);
            for (int i = 0; i < countries.Length; i++)                
                countries[i].Show_Details();
            Console.WriteLine("By Area");
            DescendingBubbleSorter.Sort(countries, DescendingBubbleSorter.IsASmallerThanB_Area);
            for (int i = 0; i < countries.Length; i++)
                countries[i].Show_Details();
        }
        var new_countries = new Country[]
            {
            new Country{ Name="Moldova", Area=200, Population=100},
            new Country{ Name="China", Area=2005, Population=1001}
            };

        DescendingBubbleSorter.Sort(new_countries, (object a, object b) =>
            {
           // return ((Country) a).Population+((Country)a).Area<((Country) b).Population+((Country) a).Area;
                       return (((Country) a).Population<((Country) b).Population);

            };
        
    }
    
}

