using System;

namespace TrialByCombat.Scrolls
{
    public partial class Scroll
    {
        public static int DeathScrollCount { get; set; } = 10;

        public static void Death()
        {
            if (DeathScrollCount >= 1) // if you have potions available
            {
                DeathScrollCount--; //subtract 1

                int oldHP = Monster.HP;

                //int Damage = Convert.ToInt32((Monster.HPmax / 100) * 10);
                Monster.HP -= 10; // 10 damage for now

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