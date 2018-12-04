using System;

namespace week7
{
    public class Fighter
    {
        public int Hp { get; set; }
        public int Attack { get; set; }
        public int Strength { get; set; }
        public string Name { get; set; }

        public Fighter() { }

        public Fighter(string name, Random random)
        {
            Hp = 50 + random.Next(1, 31);
            Attack = 6 + random.Next(1,7);
            Strength = 1 + random.Next(5);
            Name = name;
        }
    }
}
