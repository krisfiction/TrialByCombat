using System;

namespace TrialByCombat.Scrolls
{
    public partial class Scroll
    {
        public static int DeathScrollCount { get; set; } = 15;

        public static void Death()
        {
            // Instant Kill
            // No Loot, No Gold
            //TODO no loot, no gold needs added to game


            if (DeathScrollCount >= 1) // if you have potions available
            {
                DeathScrollCount--; //subtract 1

                int oldHP = Monster.HP;

                Monster.HP -= Convert.ToInt32(Monster.HP * 1.10); // monster hp + 10%

                Console.Clear();
                Console.WriteLine("you have read a Death Scroll, you did " + (Monster.HP - oldHP) + " points of damage");
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