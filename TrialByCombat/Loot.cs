using System;
using System.Collections.Generic;
using System.Text;
using TrialByCombat.Potions;
using TrialByCombat.Scrolls;

namespace TrialByCombat
{
    public class Loot
    {
        public static void Roll()
        {
            // #START loot code
            Player.Gold += Monster.Gold; // you get Gold

            Console.WriteLine();
            Console.WriteLine("you recieve " + Monster.Gold + " gold, with a total of " + Player.Gold);
            Console.WriteLine();

            Random random = new Random();
            int getLoot = random.Next(0, 10); // should roll 0 through 9, giving 10 chances
            if (getLoot == 0)
            {
                Console.WriteLine("you get a potion"); // potion count code here
                HealthPotion.Quantity += 1;
            }
            else if (getLoot == 1)
            {
                Console.WriteLine("you get a scroll"); // scroll count code here
                Scroll.MagicShieldScrollCount += 1;
            }
            else if (getLoot == 2 || getLoot == 3 || getLoot == 4) // 2, 3 or 4 - 30% chance
            {
                Generate();
            }
            else
            {
                Console.WriteLine("you get nothing");
            }
            // #END loot code

        }



        public static void Generate()
        {
            Console.WriteLine("you get gear"); // gear code here - move current gear code into these {} 

            Random random = new Random();

            int _slot = random.Next(0, 13); //returns 0, 1 - low number, top number + 1
            string[] gearSlot = new string[13];
            gearSlot[0] = "helmet"; //head
            gearSlot[1] = "shoulders";
            gearSlot[2] = "chest";
            gearSlot[3] = "belt";
            gearSlot[4] = "bracer"; // arms
            gearSlot[5] = "gloves"; // hands
            gearSlot[6] = "pants"; // legs
            gearSlot[7] = "boots"; // feet
            gearSlot[8] = "necklace"; //neck
            //TODO make ring 1 spot - maybe make ring and neck seperate as well
            //TODO make weapons seperate ?? to apply Sword, Dagger, Spear ....
            //TODO Gear() - RingNeck() - Weapon()
            gearSlot[9] = "ring"; // ring 1
            gearSlot[10] = "ring"; // ring 2
            gearSlot[11] = "main hand weapon";
            gearSlot[12] = "off hand weapon";


            int _name = random.Next(0, 5); //returns 0, 1 - low number, top number + 1
            string[] gearName = new string[5];
            gearName[0] = "padded";
            gearName[1] = "leather";
            gearName[2] = "studded leather";
            gearName[3] = "chain mail";
            gearName[4] = "plate";

            //TODO add armor class and modifers
            //TODO seperate rings, neck, weapons
            //TODO damage for weapons -- High, Low or 2d6 ??
            //TODO add name for gear - Padded Helmet, 




            Inventory.Inventories.Add(new Inventory(gearName[_name], "Gear", gearSlot[_slot], 5, "this is gear"));
            Console.WriteLine(gearName[_name] + "\t" + gearSlot[_slot]);

            //string gty = "blah";

            //Inventory.Inventories.Add(new Inventory("NEW WINNER DELUXE", "Weapon", "Main Hand", 10, "2d10", "this is a sword"));
            //Inventory.Inventories.Add(new Inventory(gty, "Gear", "Head", 5, "this is a helmet"));
        }
    }
}
