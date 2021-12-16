﻿using System;

namespace TrialByCombat
{
    public static class StatBar
    {
        public static void DisplayStatBar(Player player, Monster monster)
        {
            Console.ForegroundColor = ConsoleColor.Blue; // makes text blue - may be removed

            Console.WriteLine();
            Console.WriteLine("********************************************************************************");
            
            //this needs work if it is going to be used
            //Console.WriteLine("{0,-10}{1,-4}{2,-5}{3,-15}{4,-5}{5,20}{6,5}", Player.Name, "HP:", Player.HP, "Magic Shield:", Player.Shield, "Armor Bonus:", (Player.ChestArmorBonus + Player.HeadArmorBonus));
            
            Console.WriteLine(player.Name + "\tHP " + player.Health + "/" + player.HealthMax + "\tMagic Shield: " + player.Shield + "\t\tArmor Bonus: " + player.AC);
            Console.WriteLine(monster.Name + "\tHP " + monster.Health + "/" + monster.HealthMax);
            //Console.WriteLine("********************************************************************************");
            Console.WriteLine(("").PadRight(80, '*'));
            Console.WriteLine();


            //testing for health bar - right now only displays health percentage
            //should display as [********  ] as 80 percent health
            //should display as [**********] as 100 percent health
            //should display as [***       ] as 30 percent health
            Console.WriteLine($"health bar --> {player.DisplayHealthBar()}%");
            Console.WriteLine($"health bar --> {monster.DisplayHealthBar()}%");


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