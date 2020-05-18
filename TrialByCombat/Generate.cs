using System;
using System.Collections.Generic;
using System.Text;
using TrialByCombat.Armors;
using TrialByCombat.Potions;
using TrialByCombat.Scrolls;

namespace TrialByCombat
{
    internal static class Generate
    {
        private static readonly Random random = new Random();
        public static void Armor()
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


            string prefixName;
            int prefixValue;
            string prefixStat;
            (prefixName, prefixStat, prefixValue) = Prefix.Generate("Armor");

            string suffixName;
            string suffixStat;
            int suffixValue;
            (suffixName, suffixStat, suffixValue) = Suffix.Generate("Armor");




            //int _armorType = random.Next(1, 11);
            int _armorType = 1; //TODO remove - for testing 
            switch (_armorType)
            {
                case 1:
                    //Rags rags = new Rags(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                   
                    Rags rags = new Rags(gearSlot[_slot], prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    rags.ArmorAddToInventory();
                    break;
                //case 2:
                //    Quilted cloak = new Quilted(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                //    cloak.ArmorAddToInventory();
                //    break;
                //case 3:
                //    Leather leather = new Leather(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                //    leather.ArmorAddToInventory();
                //    break;
                //case 4:
                //    HardLeather hardLeather = new HardLeather(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                //    hardLeather.ArmorAddToInventory();
                //    break;
                //case 5:
                //    StuddedLeather studdedLeather = new StuddedLeather(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                //    studdedLeather.ArmorAddToInventory();
                //    break;
                //case 6:
                //    RingMail ringMail = new RingMail(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                //    ringMail.ArmorAddToInventory();
                //    break;
                //case 7:
                //    ChainMail chainMail = new ChainMail(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                //    chainMail.ArmorAddToInventory();
                //    break;
                //case 8:
                //    ScaleMail scaleMail = new ScaleMail(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                //    scaleMail.ArmorAddToInventory();
                //    break;
                //case 9:
                //    FieldPlate fieldPlate = new FieldPlate(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                //    fieldPlate.ArmorAddToInventory();
                //    break;
                //case 10:
                //    GothicPlate gothicPlate = new GothicPlate(gearSlot[_slot], prefixName[_prefixRandom], "Armor", 5, suffixName[_suffixRandom], "Health", 5);
                //    gothicPlate.ArmorAddToInventory();
                //    break;

            }
        }
    }
}
