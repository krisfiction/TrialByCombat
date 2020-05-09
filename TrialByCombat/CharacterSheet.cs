using System;
using System.Collections.Generic;
using System.Text;
using TrialByCombat.Scrolls;
using TrialByCombat.Potions;

namespace TrialByCombat
{
    class CharacterSheet
    {
        public static void Display()
        {
            Console.Clear();
            Console.WriteLine("character Sheet");
            Console.WriteLine();
            Console.WriteLine("Name: " + Player.Name);
            Console.WriteLine("Health: " + Player.HP + "/" + Player.HP);
            Console.WriteLine("Armor Bonus: " + (Player.HeadArmorBonus + Player.ChestArmorBonus));
            Console.WriteLine();
            Console.WriteLine("Gold: " + Player.Gold);
            Console.WriteLine();
            Console.WriteLine("Equipment:");
            Console.WriteLine("Head: " + Player.HeadName + " +" + Player.HeadArmorBonus);
            Console.WriteLine("Chest: " + Player.ChestName + " +" + Player.ChestArmorBonus);
            Console.WriteLine();
            Console.WriteLine("Inventory:");
            Console.WriteLine("Heal Potions: " + Potion.HealPotionCount);
            Console.WriteLine("Macgic Shield Scrolls: " + Scroll.MagicShieldScrollCount);





            Console.WriteLine();
            Console.WriteLine("press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            StatBar.DisplayStatBar();
        }
    }
}
 