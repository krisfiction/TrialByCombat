using System;

namespace TrialByCombat.Potions
{
    public partial class Potion
    {
        public static void Shield()
        {
            Player.Shield += 50;
            Console.WriteLine();
            Console.WriteLine("you cast Magic Shield, currently protecting you from " + Player.Shield + " damage");
            Console.WriteLine();
        }
    }
}