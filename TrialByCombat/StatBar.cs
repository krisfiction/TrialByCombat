using System;

namespace TrialByCombat
{
    public class StatBar
    {
        public static void DisplayStatBar()
        {  
            Console.WriteLine();
            Console.WriteLine("********************************************************************************");
            Console.WriteLine(Player.Name + "\t HP " + Player.HP + "\tMagic Shield: " + Player.Shield + "\t\t" + Monster.Name + ", HP " + Monster.HP);
            Console.WriteLine("Chest: " + Player.ChestName + " +" + Player.ChestArmorBonus + "\t" + "Back: " + Player.BackName + " +" + Player.BackArmorBonus + "\tGold: " + Player.Gold);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine();
        }
    }
}
