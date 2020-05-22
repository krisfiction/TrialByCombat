using System;
using System.Collections.Generic;
using System.Text;
using TrialByCombat.Scrolls;
using TrialByCombat.Potions;

namespace TrialByCombat
{
    internal static class CharacterSheet
    {
        public static void Display(Player player)
        {
            Console.Clear();
            Console.WriteLine("character Sheet");
            Console.WriteLine();
            Console.WriteLine("Name: " + player.Name);
            Console.WriteLine("Health: " + player.Health + "/" + player.HealthMax);
            Console.WriteLine("Armor Bonus: " + (player.HeadArmorBonus + player.ChestArmorBonus));
            Console.WriteLine();
            Console.WriteLine("Gold: " + player.Gold);
            Console.WriteLine();
            Console.WriteLine("Weapon: " + Variables.weaponName + " " + Variables.weaponDamageLow + "-" + Variables.weaponDamageHigh + " damage");
            Console.WriteLine();
            Console.WriteLine("Equipment:");
            Console.WriteLine("Head: " + player.HeadName + " +" + player.HeadArmorBonus);
            Console.WriteLine("Chest: " + player.ChestName + " +" + player.ChestArmorBonus);
            Console.WriteLine();
            Console.WriteLine("Supplies:");
            Console.WriteLine("Health Potions: " + HealthPotion.Quantity);
            Console.WriteLine("Magic Shield Scrolls: " + Scroll.MagicShieldScrollCount);
            Console.WriteLine("Death Scrolls: " + Scroll.DeathScrollCount);





            Console.WriteLine();
            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
        }
    }
}
 