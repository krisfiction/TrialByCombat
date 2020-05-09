using System;

namespace TrialByCombat
{
    public class StatBar
    {
        public static void DisplayStatBar()
        {
            Console.ForegroundColor = ConsoleColor.Blue; // makes text blue - may be removed

            Console.WriteLine();
            Console.WriteLine("********************************************************************************");
            
            //this needs work if it is going to be used
            //Console.WriteLine("{0,-10}{1,-4}{2,-5}{3,-15}{4,-5}{5,20}{6,5}", Player.Name, "HP:", Player.HP, "Magic Shield:", Player.Shield, "Armor Bonus:", (Player.ChestArmorBonus + Player.HeadArmorBonus));
            
            Console.WriteLine(Player.Name + "\tHP " + Player.HP + "/" + Player.HPmax + "\tMagic Shield: " + Player.Shield + "\t\tArmor Bonus: " + (Player.ChestArmorBonus + Player.HeadArmorBonus));
            Console.WriteLine(Monster.Name + "\tHP " + Monster.HP + "/" + Monster.HPmax);
            Console.WriteLine("********************************************************************************");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
/* 
 * maybe create a display method / buffer thingy
 * 
 * WL(input); // this will call Console.Writeline() and save last 25 lines
 * 
 * make last 5 lines be actions text - you have hit monster for 20 damage or you have take a heal potion for 60HP
 * 
 * make top line for stats - like DisplayStatBar()
 * 
 * default console size is 80x25
 * 
 */