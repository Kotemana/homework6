using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    public class Battle
    {
        //heh
        public void FirstStar()
        {
            List<Faction> factions = new List<Faction>();
            var random = new Random();

            Faction elves = new Faction() { Name = "Elves", Squads = new List<Squad>() };
            Squad archers = new Squad() { Name = "Elven Archers" };
            Squad mages = new Squad() { Name = "Elven mages" };

            elves.Squads.Add(archers);
            elves.Squads.Add(mages);


            Faction orcs = new Faction() { Name = "Orcs" , Squads = new List<Squad>() };
            Squad fighters = new Squad() { Name = "Orc fighters" };
            Squad urukKhai = new Squad() { Name = "Uruk Khai" };

            orcs.Squads.Add(fighters);
            orcs.Squads.Add(urukKhai);


            factions.Add(elves);
            factions.Add(orcs);

            foreach (var faction in factions)
            {
                foreach (var squad in faction.Squads)
                {
                    List<string> namesList = GenerateNames("Names.txt");
                    squad.Fighters = GenerateFighters(namesList, random, 10);
                }
            }

            foreach (var faction in factions)
            {
                faction.Report();
            }

            Fighter bob=archers.Fighters.FirstOrDefault(x => x.Name == "Bob");
            if (bob != null)
            {
                Console.WriteLine($"bob has {bob.Hp} hp");
            }
            else
            {
                Console.WriteLine("no bob found");
            }

            List<Fighter> tanks = archers.Fighters.Where(x => x.Hp > 70).ToList();
            foreach (var bobby in tanks)
            {
                Console.WriteLine($"Tank {bobby.Name} has {bobby.Hp} hp");
            }
        }

        private List<string> GenerateNames(string path)
        {
            string line;
            List<string> names = new List<string>();
            using (var file = new System.IO.StreamReader(path))
            {
                while ((line = file.ReadLine()) != null)
                {
                    names.Add(line);
                }
            }
            return names;
        }

        private List<Fighter> GenerateFighters(List<string> names, Random random, int number)
        {
            List<Fighter> fighters = new List<Fighter>();
            for (int i = 0; i < number; i++)
            {
                string name = names[random.Next(names.Count)];
                fighters.Add(new Fighter(name, random));
            }
            return fighters;
        }
    }
}
