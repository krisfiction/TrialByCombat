using System;

namespace TrialByCombat.Scrolls
{
    public partial class Potion
    {
        public static int HealPotionCount { get; set; } = 10;

        public static void Heal()
        {
            if (Player.HPmax == Player.HP) // if already at max health
            {
                Console.Clear();
                Console.WriteLine("You are already at max health!");
                Console.WriteLine();
                StatBar.DisplayStatBar();
            }
            else
                if (HealPotionCount >= 1) // if you have potions available
            {
                    HealPotionCount -= 1;
                    int oldHP = Player.HP;
                   // Player.HP += Convert.ToInt32((Player.HPmax / 100) * 60); // Convert.ToInt32 to prevent half numbers like 59.3 hp
                                                                             //Player.HP += (Player.HPmax / 100) * 60; //60% based on max hp
                    int tooHeal = Convert.ToInt32((Player.HPmax / 100) * 60);

                if ((Player.HP + tooHeal) > Player.HPmax) // if the potion will heal over max hp
                {
                    Player.HP = Player.HPmax;
                }
                else
                {
                    Player.HP += tooHeal;
                }

                Console.Clear();
                    Console.WriteLine("you have used a 60% heal potion, you gained " + (Player.HP - oldHP) + "hp,  you are now at " + Player.HP + "hp");
                    Console.WriteLine();
                    StatBar.DisplayStatBar();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("you have no Heal Potions available");
                    Console.WriteLine();
                    StatBar.DisplayStatBar();
                }
        }
    }
}
/*
https://diablo.fandom.com/wiki/Healing_Potions

Minor Health Potion
Lesser Health Potion
Health Potion
Greater Health Potion
Major Health Potion
Super Health Potion
Heroic Health Potion
Resplendent Health Potion
Runic Health Potion
Mythic Health Potion

10 potions - use at 10% each 
*/
