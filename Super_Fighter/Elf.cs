using System;
using System.Linq;

namespace Super_Fighter
{
    public class Elf : Hero
    {
        private static Random _random = new Random();

        public Elf(string name) : base(name)
        {
            Health = 4;
            Attacks.Add("Elven special", 2.5 );
            Defends.Add("Potion", 2.5);
            Defends.Add("Confusion", 3);
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