using System;
using System.Collections.Generic;

namespace BehavioralPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject();
            Observer observer1 =new Observer("Observer nr 1");
            subject.Subscribe(observer1);
            subject.Inventory++;
            subject.Unsubscribe(observer1);
            subject.Inventory--;
            Observer observer2 = new Observer("Observer nr 2");
            subject.Subscribe(observer2);
            subject.Inventory++; 
            Observer observer3 = new Observer("Observer nr 3");
            subject.Subscribe(observer3);
            subject.Inventory++;

            SortedList sortedList = new SortedList();
            sortedList.SortStrategy = new SortByName();
            List<Person>PersonsToSortList =new List<Person>()
            {
                new Person(){Name="Ion", Age = 14},
                new Person() { Name = "Doina", Age = 24 },
                new Person() { Name = "Emilia", Age = 4 }
            };
            List<Person> result = sortedList.GetSortedListofPersons();
            
            foreach (Person p in result)
                {
                    Console.WriteLine($"Name {p.Name} Age {p.Age}");
                }
            
            Console.WriteLine();
        }
    }
}
