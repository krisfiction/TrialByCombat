using System;
using TrialByCombat.Armors;
using TrialByCombat.Potions;
using TrialByCombat.Scrolls;

namespace TrialByCombat
{
    public static class Loot
    {
        private static readonly Random random = new Random();

        public static void Roll(Player player, Monster monster)
        {
            player.Gold += monster.Gold; // you get Gold

            Console.WriteLine();
            Console.WriteLine("you recieve " + monster.Gold + " gold, with a total of " + player.Gold);
            Console.WriteLine();

            int getLoot = random.Next(0, 10); // should roll 0 through 9, giving 10 chances
            if (getLoot == 0)
            {
                Console.WriteLine("you get a potion"); // potion count code here
                HealthPotion.Quantity++; //TODO needs moved to Generate.Potion()
            }
            else if (getLoot == 1)
            {
                Console.WriteLine("you get a scroll"); // scroll count code here
                Scroll.MagicShieldScrollCount++; //TODO need moved to Generate.Scroll()
            }
            else if (getLoot == 2 || getLoot == 3 || getLoot == 4) // 2, 3 or 4 - 30% chance
            {
                Console.WriteLine("you get Gear!");
                Generate.Armor(); //need method for other loot - Jewelry, Weapons, etc...
            }
            else if (getLoot == 5 || getLoot == 6 || getLoot == 7) // 2, 3 or 4 - 30% chance
            {
                Console.WriteLine("you get a Weapon!");
                Generate.Weapon();
            }
            else
            {
                Console.WriteLine("you get nothing");
            }
            
        }
    }
}

