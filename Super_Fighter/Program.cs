using System;
using System.Linq;

namespace Super_Fighter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new Character
            Init(out string userInput, out string name);
            Hero player = null;
            switch (userInput)
            {
                case "wizard":
                    player = new Wizard(name);
                    break;
                case "elf":
                    player = new Elf(name);
                    break;
            }

            // Create opponent
            Hero aiPlayer = null;
            if (userInput.GetType().Name.Equals(
                "Wizard"))
                aiPlayer = new Elf("Legolas");

            else
                aiPlayer = new Wizard("Harry");

            Console.WriteLine();

            // Start
            Battle.Fight(player, aiPlayer);

            Console.ReadKey(true);
        }

        private static void Init(out string userInput, out string name)
        {
            bool valid = false;

            do
            {
                // Get type
                Console.WriteLine("Choose your fighter: wizard or elf");
                userInput = Console.ReadLine().ToLower();

                // Validate
                if (!(userInput == "wizard" || userInput == "elf"))
                    Console.WriteLine("Must be a wizard or elf");

                else
                    valid = true;
            } while (!valid);
            do
            {
                // Get name
                Console.WriteLine("Name your fighter : ");
                name = Console.ReadLine();

                // Validate -- Only accept chars
                valid = (!name.Any(x => char.IsDigit(x)));
                if (!valid || name.Trim().Equals(""))
                    Console.WriteLine("Name must not contain #s or be empty");

            } while (!valid || name.Trim().Equals(""));
        }
    }
}
