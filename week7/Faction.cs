using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7
{
    public class Faction
    {
        public List<Squad> Squads { get; set; }
        public string Name { get; set; }

        public void Report()
        {
            Console.WriteLine($"{Name} Faction Reporting. We have {Squads.Count} squads:");
            foreach (var squad in Squads)
            {
                Console.WriteLine($"{squad.Name} squad Reporting. We have {squad.Fighters.Count} fighters:");
                foreach (var fighter in squad.Fighters)
                {
                    Console.WriteLine($"{fighter.Name} fighter Reporting. I have {fighter.Hp} health, {fighter.Attack} attack, {fighter.Strength} strength");
                }

            }
        }
    }
}
