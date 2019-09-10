using System;

namespace Super_Fighter
{
    internal class HelperClass
    {
        internal static void Title()
        {
            Console.Title = "\tSuper Fighter";
            string title = @"
 ____ ____ ____ ____ ____ _________ ____ ____ ____ ____ ____ ____ ____ 
||s |||u |||p |||e |||r |||       |||f |||i |||g |||h |||t |||e |||r ||
||__|||__|||__|||__|||__|||_______|||__|||__|||__|||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|/__\|/_______\|/__\|/__\|/__\|/__\|/__\|/__\|/__\|";
            Console.WriteLine(title);
            Console.WriteLine("\n\t\t\t\tPress any key to continue...");
            Console.ReadKey(true);
        }

        internal static void Match(Hero heroOne, Hero heroTwo)
        {
            Console.Clear();
            Console.WriteLine("Two enter : One leaves ");
            Console.WriteLine("\t{0} vs {1}", heroOne.Name, heroTwo.Name);
            Console.WriteLine("\n\n\n\t\t\tPress any key to continue...");
            Console.ReadKey(true);
            Console.Clear();
        }

        internal static void Fin(Hero hero)
        {
            Console.ReadKey(true);
            Console.Clear();
            Console.WriteLine("\t\t\t\t" + hero.Name + " Lost!!!\n");
            Console.Title = "\tEl Fin";
            string Fin = @"
 ____ ____ ____ ____ _________ ____ ____ ____ ____ 
||G |||a |||m |||e |||       |||O |||v |||e |||r ||
||__|||__|||__|||__|||_______|||__|||__|||__|||__||
|/__\|/__\|/__\|/__\|/_______\|/__\|/__\|/__\|/__\|";
            Console.WriteLine(Fin);
            Console.WriteLine("\n\n\n\t\t\tPress any key to continue...");
        }
    }
}