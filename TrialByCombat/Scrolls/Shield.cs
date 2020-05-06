using System;

namespace TrialByCombat.Scrolls
{
    public partial class Scroll
    {
        public static int MagicShieldScrollCount { get; set; } = 5;
        public static void MagicShield()
        {
            
            if (MagicShieldScrollCount >= 1)
            {
                MagicShieldScrollCount -= 1;

                Player.Shield += 50;
                Console.Clear();
                Console.WriteLine("you read a Magic Shield scroll, currently protecting you from " + Player.Shield + " damage");
                Console.WriteLine();
                StatBar.DisplayStatBar();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("you have no Magic Shield Scrolls available");
                Console.WriteLine();
                StatBar.DisplayStatBar();
            }
        }
    }
}

//add monster attack after reading scroll ??
//scroll take a turn vs potion and attack being 1 turn ??