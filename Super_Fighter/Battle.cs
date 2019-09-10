using System;

namespace Super_Fighter
{
    internal class Battle
    {
        internal static void Fight(Hero player, Hero aiPlayer)
        {
            int round = 1;

            // Helpers
            HelperClass.Title();
            HelperClass.Match(player, aiPlayer);

            // Battle
            do
            {
                Console.WriteLine("\n{0}\t\t\t{1}{2}\t\tvs\t\t{3}\t\t\t{4}{5}\n",
                 player.Name, "Health :", player.Health, aiPlayer.Name, "Health :", aiPlayer.Health);
                Console.WriteLine("ROUND : " + round);


                double diff = player.Attack() - aiPlayer.Defend();
                aiPlayer.Health -= diff;
                if (aiPlayer.Health <= 0)
                {
                    Console.WriteLine(aiPlayer.Name + " Has Fallen");
                    HelperClass.Fin(aiPlayer);
                    return;
                }

                double diff2 = aiPlayer.Attack() - player.Defend();
                player.Health -= diff2;
                if (player.Health <= 0)
                {
                    Console.WriteLine(player.Name + " Screams");
                    HelperClass.Fin(player);
                    return;
                }
                round++;
            } while (player.Health >= 0 || aiPlayer.Health >= 0);
        }
    }
}