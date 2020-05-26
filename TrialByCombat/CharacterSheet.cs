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
            Console.WriteLine("Armor Bonus: " + (player.AC + player.HeadArmorBonus + player.ShouldersArmorBonus + player.ArmsArmorBonus + player.HandsArmorBonus + player.ChestArmorBonus + player.WaistArmorBonus + player.LegsArmorBonus + player.FeetArmorBonus));
            Console.WriteLine();
            Console.WriteLine("Gold: " + player.Gold);
            Console.WriteLine();
            Console.WriteLine("Weapon: " + player.WeaponName + " " + player.WeaponDamageLow + "-" + player.WeaponDamageHigh + " damage");
            Console.WriteLine();
            Console.WriteLine("Equipment:");
            Console.WriteLine("Head: " + player.HeadName + " +" + player.HeadArmorBonus);
            Console.WriteLine("Shoulders: " + player.ShouldersName + " +" + player.ShouldersArmorBonus);
            Console.WriteLine("Arms: " + player.ArmsName + " +" + player.ArmsArmorBonus);
            Console.WriteLine("Hands: " + player.HandsName + " +" + player.HandsArmorBonus);
            Console.WriteLine("Chest: " + player.ChestName + " +" + player.ChestArmorBonus);
            Console.WriteLine("Waist: " + player.WaistName + " +" + player.WaistArmorBonus);
            Console.WriteLine("Legs: " + player.LegsName + " +" + player.LegsArmorBonus);
            Console.WriteLine("Feet: " + player.FeetName + " +" + player.FeetArmorBonus);
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
 