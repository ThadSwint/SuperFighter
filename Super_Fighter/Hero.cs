using System.Collections.Generic;

namespace Super_Fighter
{
    public abstract class Hero : IFighter
    {
        public string Name { get; protected set; }
        internal double Health { get; set; }

        public Dictionary<string, double> Attacks { get; protected set; }
        public Dictionary<string, double> Defends { get; protected set; }

        // Build in some encapsulation for future features
        public Hero(string name)
        {
            Name = name;
            Attacks = new Dictionary<string, double>
            {
                {"strike", .5 },
                {"hard punch", 1 },
                {"kick", 1.5 },
                {"super kick", 2.5 }
            };
            Defends = new Dictionary<string, double>
            {
                {"block", .5 },
                {"parry", 1 }
            };
        }
        public abstract double Attack();
        public abstract double Defend();
    }
}