using System;
using System.Linq;

namespace Super_Fighter
{
    public class Wizard : Hero
    {
        private static readonly Random _random = new Random();

        public Wizard(string name) : base(name)
        {
            Health = 3;
            Attacks.Add("Wizard special", 2.5);
            Defends.Add("Summon", 2);
            Defends.Add("wand wave", 1.5);
        }

        public override double Attack()
        {
            var x = Attacks.ToList()[_random.Next(Attacks.Count)];
            Console.WriteLine(Name + " throws " + x.Key + " @ : " + x.Value + " damage");
            return x.Value;
        }

        public override double Defend()
        {
            var x = Defends.ToList()[_random.Next(Attacks.Count)];
            Console.WriteLine(Name + " counters with " + x.Key + " for : " + x.Value);
            return x.Value;
        }

        private static int GetRandomNumber(int low, int high) => _random.Next();
    }
}