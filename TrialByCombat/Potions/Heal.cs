using System;

namespace TrialByCombat.Potions
{
    public partial class Potion
    {
        public static void Heal()
        {
            int oldHP = Player.HP;
            Player.HP += Convert.ToInt32((Player.HPmax / 100) * 60); // Convert.ToInt32 to prevent half numbers like 59.3 hp
            //Player.HP += (Player.HPmax / 100) * 60; //60% based on max hp
            Console.Clear();
            Console.WriteLine("you have used a 60% heal potion, you gained " + (Player.HP - oldHP) + "hp,  you are now at " + Player.HP + "hp");
            Console.WriteLine();

            //StatBar statbar = new StatBar();
            //statbar.DisplayStatBar();
            StatBar.DisplayStatBar();
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
