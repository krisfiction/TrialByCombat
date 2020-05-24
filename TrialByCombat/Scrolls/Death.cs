using System;

namespace TrialByCombat.Scrolls
{
    public partial class Scroll
    {
        public static int DeathScrollCount { get; set; } = 15;

        public static void Death(Monster monster)
        {
            // Instant Kill
            // No Loot, No Gold
            //TODO no loot, no gold needs added to game


            if (DeathScrollCount >= 1) // if you have potions available
            {
                DeathScrollCount--; //subtract 1

                int oldHP = monster.Health;

                monster.Health -= Convert.ToInt32(monster.Health * 1.10); // monster hp + 10%

                Console.Clear();
                Console.WriteLine("you have read a Death Scroll, you did " + Convert.ToInt32(oldHP * 1.10) + " points of damage");
                Console.WriteLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("you have no Death Scrolls available");
                Console.WriteLine();
            }
        }
    }
}