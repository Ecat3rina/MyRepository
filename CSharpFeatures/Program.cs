using System;
using System.Collections.Generic;

namespace CSharpFeatures
{
    class Program
    {
        static void Main(string[] args)
        {
            Show_Info(rank:4,name:"Federer");
            //Show_Info(name: "Federer", rank: 4,canPlay:false);
            
            dynamic players = new List<TennisPlayer> 
            {
                new TennisPlayer{ Name="Djokovic", ATP_Rank=1 },
                new TennisPlayer{ Name="Nadal", ATP_Rank=2 },
                new TennisPlayer{ Name="Albot", ATP_Rank=66 }
            };
            dynamic position = 1;
            foreach (dynamic player in players)
            {
                int player_rank = player.ATP_Rank + position;
                Console.WriteLine(player_rank);
            }

            string name = "dominic";
            try
            {
                throw new Exception("Wrong name!");
            }
            catch (Exception ex) when (Char.IsDigit(Get_Name(name)))
            {
                Console.WriteLine($"Personal name \"{name}\" has digit");
            }
            catch (Exception ex) when (Char.IsWhiteSpace(Get_Name(name)))
            {
                Console.WriteLine($"Personal name \"{name}\" has white space", name);
            }
            catch (Exception ex) when (Char.IsLower(Get_Name(name)))
            {
                Console.WriteLine($"Personal name \"{name}\" starts with lower letter", name);
            }
            var player2 = new TennisPlayer
            {
                Name = "Agassi",
                ATP_Rank = null
            };
            Check_Rank(player2);
           
        }
        public static void Show_Info(string name, int rank, bool canPlay=true)
        {
            Console.WriteLine($"Tennis player name is {name}");
            Console.WriteLine($"Tennis player rank is {rank} ATP");
            Console.WriteLine($"Can he play?-{canPlay}");
        }
        public static char Get_Name(string name)
        {
            if (name == null)
                throw new Exception($"Name {nameof(name)} is null");
            return name[0];
        }
    public static void Check_Rank(TennisPlayer player)
            {
            var result_rank=player?.ATP_Rank ?? 0;
            if (result_rank==0)
                Console.WriteLine("Innactive player");
            else
            Console.WriteLine("Active player");
        }
    }
}
