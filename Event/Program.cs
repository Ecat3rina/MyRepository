using System;
using System.Collections.Generic;
using System.Threading;

namespace Event
{
    class Program
    {
                
        static void Main(string[] args)
        {
            var customers = new List<Customer>()
            {
                new Customer{ Name="John", food="pizza"},
                new Customer{ Name="Alex", food="salad"},
                new Customer{ Name="Liza", food="salad"},
                new Customer{ Name="Liza", food="pizza"}
            };
            
            Console.WriteLine("Which type of food will chef cook?");
            string type_of_food = Console.ReadLine();
            var cooker = new Chef();
            foreach (var c in customers)
            {
                if (c.food == type_of_food)
                {
                    Console.WriteLine($"{c.Name}!");
                    cooker.CookFood(type_of_food);
                    
                }
            }
        }
        
        public static void OnRequest(FoodCookedEventArgs args)
        {
            
            Console.WriteLine($" {args.FoodType} are in process.. ");
            Thread.Sleep(1000);
            Console.Clear();

            Console.Write("1. ");
            Thread.Sleep(1000);
            
            Console.Write("2.. ");
            Thread.Sleep(1000);
           
            Console.Write("3...");
            Thread.Sleep(1000);
            Console.Clear();
        }
        public static void RequestCompleted(FoodCookedEventArgs args)
        {            
            Console.WriteLine($"{args.FoodType} is ready ");
            Thread.Sleep(3000);
            Console.Clear();
        }

    }
}
