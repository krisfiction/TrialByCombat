using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Net.NetworkInformation;
using System.Runtime.CompilerServices;
using System.Text;
using TrialByCombat.Armors;
using TrialByCombat.Potions;
using TrialByCombat.Scrolls;

namespace TrialByCombat
{
    public static class Loot
    {
        private static readonly Random random = new Random();

        public static void Roll()
        {
            // #START loot code
            Player.Gold += Monster.Gold; // you get Gold

            Console.WriteLine();
            Console.WriteLine("you recieve " + Monster.Gold + " gold, with a total of " + Player.Gold);
            Console.WriteLine();

            //Random random = new Random();
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
                GenerateArmor(); //need method for other loot - Jewelry, Weapons, etc...
            }
            else
            {
                Console.WriteLine("you get nothing");
            }
            // #END loot code
        }


        public static void GenerateArmor()
        {
            int _slot = random.Next(0, 8);
            string[] gearSlot = new string[8];
            gearSlot[0] = "helmet"; //head
            gearSlot[1] = "shoulders";
            gearSlot[2] = "chest";
            gearSlot[3] = "belt";
            gearSlot[4] = "bracer"; // arms
            gearSlot[5] = "gloves"; // hands
            gearSlot[6] = "pants"; // legs
            gearSlot[7] = "boots"; // feet

            int _prefixRandom = random.Next(0, 12);   //armor class
            string[] prefixName = new string[12];
            prefixName[0] = "Vulnerable";
            prefixName[1] = "Rusted";
            prefixName[2] = "Fine";
            prefixName[3] = "Strong";
            prefixName[4] = "Grand";
            prefixName[5] = "Valiant";
            prefixName[6] = "Glorious";
            prefixName[7] = "Blessed";
            prefixName[8] = "Saintly";
            prefixName[9] = "Awesome";
            prefixName[10] = "Holy";
            prefixName[11] = "Godly";

            //todo add prefixLow, prefixHigh
            //just prefix and suffix names for now

            int _suffixRandom = random.Next(0, 10);
            string[] suffixName = new string[10]; // life
            suffixName[0] = "Vulture";
            suffixName[1] = "Jackal";
            suffixName[2] = "Fox";
            suffixName[3] = "Jaguar";
            suffixName[4] = "Eagle";
            suffixName[5] = "Wolf";
            suffixName[6] = "Tiger";
            suffixName[7] = "Lion";
            suffixName[8] = "Mammoth";
            suffixName[9] = "Whale";

            //generate Armor code
            //todo add random info for prefix and suffix stuff
            int _armorType = random.Next(1, 11);
            switch (_armorType)
            {
                case 1:
                    Rags rags = new Rags(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                    rags.ArmorAddToInventory();
                    break;
                case 2:
                    Quilted cloak = new Quilted(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                    cloak.ArmorAddToInventory();
                    break;
                case 3:
                    Leather leather = new Leather(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                    leather.ArmorAddToInventory();
                    break;
                case 4:
                    HardLeather hardLeather = new HardLeather(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                    hardLeather.ArmorAddToInventory();
                    break;
                case 5:
                    StuddedLeather studdedLeather = new StuddedLeather(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                    studdedLeather.ArmorAddToInventory();
                    break;
                case 6:
                    RingMail ringMail = new RingMail(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                    ringMail.ArmorAddToInventory();
                    break;
                case 7:
                    ChainMail chainMail = new ChainMail(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                    chainMail.ArmorAddToInventory();
                    break;
                case 8:
                    ScaleMail scaleMail = new ScaleMail(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                    scaleMail.ArmorAddToInventory();
                    break;
                case 9:
                    FieldPlate fieldPlate = new FieldPlate(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                    fieldPlate.ArmorAddToInventory();
                    break;
                case 10:
                    GothicPlate gothicPlate = new GothicPlate(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                    gothicPlate.ArmorAddToInventory();
                    break;

            }
        }
    }
}
