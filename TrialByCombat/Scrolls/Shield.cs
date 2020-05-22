using System;

namespace TrialByCombat.Scrolls
{
    public partial class Scroll
    {
        public static int MagicShieldScrollCount { get; set; } = 5;
        public static void MagicShield(Player player)
        {
            
            if (MagicShieldScrollCount >= 1)
            {
                MagicShieldScrollCount -= 1;

                player.Shield += 50;
                Console.Clear();
                Console.WriteLine("you read a Magic Shield scroll, currently protecting you from " + player.Shield + " damage");
                Console.WriteLine();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("you have no Magic Shield Scrolls available");
                Console.WriteLine();
            }
        }
    }
}

//attack of opportunity
//add monster attack after reading scroll ??
//scroll take a turn vs potion and attack being 1 turn ??