using System;
using System.Collections.Generic;
using System.Text;
using TrialByCombat.Armors;
using TrialByCombat.Potions;
using TrialByCombat.Scrolls;
using TrialByCombat.Weapons;

namespace TrialByCombat
{
    internal static class Generate
    {
        private static readonly Random random = new Random();

        //todo Potion()
        //todo Scoll()
        //todo Weapon()
        //todo Shield()
        //todo Jewelry()
        //todo Quest Item, Junk, Gems, Keys, Runes, Charms, Tomes, Arrows, Bolts, Bows, Crossbow, Staves, Wands, etc ....



        public static void Weapon()
        {
            string prefixName;
            int prefixValue;
            string prefixStat;
            (prefixName, prefixStat, prefixValue) = Prefix.Generate("Weapon");

            string suffixName;
            string suffixStat;
            int suffixValue;
            (suffixName, suffixStat, suffixValue) = Suffix.Generate("Weapon");


            //int _weaponType = random.Next(1, 11);
            int _weaponType = 1;
            switch (_weaponType)
            {
                case 1:
                    Axe axe = new Axe(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                   // Console.WriteLine("prefixName: " + prefixName + ", prefixStat: " + prefixStat + ", prefixValue: " + prefixValue + ", suffixName: " + suffixName + ", suffixStat: " + suffixStat + ", suffixVallue: " + suffixValue);
                    axe.WeaponAddToInventory();
                    break;
            }
        }


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


            int _armorType = random.Next(1, 11);
            switch (_armorType)
            {
                case 1:
                    Rags rags = new Rags(gearSlot[_slot], prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    rags.ArmorAddToInventory();
                    break;
                case 2:
                    Quilted cloak = new Quilted(gearSlot[_slot], prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    cloak.ArmorAddToInventory();
                    break;
                case 3:
                    Leather leather = new Leather(gearSlot[_slot], prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    leather.ArmorAddToInventory();
                    break;
                case 4:
                    HardLeather hardLeather = new HardLeather(gearSlot[_slot], prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    hardLeather.ArmorAddToInventory();
                    break;
                case 5:
                    StuddedLeather studdedLeather = new StuddedLeather(gearSlot[_slot], prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    studdedLeather.ArmorAddToInventory();
                    break;
                case 6:
                    RingMail ringMail = new RingMail(gearSlot[_slot], prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    ringMail.ArmorAddToInventory();
                    break;
                case 7:
                    ChainMail chainMail = new ChainMail(gearSlot[_slot], prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    chainMail.ArmorAddToInventory();
                    break;
                case 8:
                    ScaleMail scaleMail = new ScaleMail(gearSlot[_slot], prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    scaleMail.ArmorAddToInventory();
                    break;
                case 9:
                    FieldPlate fieldPlate = new FieldPlate(gearSlot[_slot], prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    fieldPlate.ArmorAddToInventory();
                    break;
                case 10:
                    GothicPlate gothicPlate = new GothicPlate(gearSlot[_slot], prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    gothicPlate.ArmorAddToInventory();
                    break;
            }
        }
    }
}
