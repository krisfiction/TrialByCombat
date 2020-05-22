﻿using System;
using System.Collections.Generic;
using System.Text;
using TrialByCombat.Armors;
using TrialByCombat.Monsters;
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

        public static void Monster(Monster monster)
        {
            int _monster = random.Next(1, 3);
            switch (_monster)
            {
                case 1:
                    Goblin goblin = new Goblin();
                    monster.Name = goblin.Name;
                    monster.Health = goblin.Health;
                    monster.HealthMax = goblin.HealthMax;
                    monster.DamageRoll = goblin.DamageRoll;
                    monster.Damage = goblin.Damage;
                    monster.Gold = goblin.Gold;
                    break;
                case 2:
                    Rat rat = new Rat();
                    monster.Name = rat.Name;
                    monster.Health = rat.Health;
                    monster.HealthMax = rat.HealthMax;
                    monster.DamageRoll = rat.DamageRoll;
                    monster.Damage = rat.Damage;
                    monster.Gold = rat.Gold;
                    break;


            }
        }

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


            int _weaponType = random.Next(1, 27); //26 weapons
            //int _weaponType = 1;
            switch (_weaponType)
            {
                case 1:
                    Axe axe = new Axe(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                   // Console.WriteLine("prefixName: " + prefixName + ", prefixStat: " + prefixStat + ", prefixValue: " + prefixValue + ", suffixName: " + suffixName + ", suffixStat: " + suffixStat + ", suffixVallue: " + suffixValue);
                    axe.WeaponAddToInventory();
                    break;
                case 2:
                    BastardSword bastardSword = new BastardSword(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    bastardSword.WeaponAddToInventory();
                    break;
                case 3:
                    BattleAxe battleAxe = new BattleAxe(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    battleAxe.WeaponAddToInventory();
                    break;
                case 4:
                    Blade blade = new Blade(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    blade.WeaponAddToInventory();
                    break;
                case 5:
                    BroadAxe broadAxe = new BroadAxe(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    broadAxe.WeaponAddToInventory();
                    break;
                case 6:
                    BroadSword broadSword = new BroadSword(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    broadSword.WeaponAddToInventory();
                    break;
                case 7:
                    Claymore claymore = new Claymore(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    claymore.WeaponAddToInventory();
                    break;
                case 8:
                    Club club = new Club(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    club.WeaponAddToInventory();
                    break;
                case 9:
                    Dagger dagger = new Dagger(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    dagger.WeaponAddToInventory();
                    break;
                case 10:
                    Falchion falchion = new Falchion(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    falchion.WeaponAddToInventory();
                    break;
                case 11:
                    Flail flail = new Flail(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    flail.WeaponAddToInventory();
                    break;
                case 12:
                    GreatAxe greatAxe = new GreatAxe(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    greatAxe.WeaponAddToInventory();
                    break;
                case 13:
                    GreatSword greatSword = new GreatSword(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    greatSword.WeaponAddToInventory();
                    break;
                case 14:
                    LargeAxe largeAxe = new LargeAxe(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    largeAxe.WeaponAddToInventory();
                    break;
                case 15:
                    LongSword longSword = new LongSword(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    longSword.WeaponAddToInventory();
                    break;
                case 16:
                    Mace mace = new Mace(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    mace.WeaponAddToInventory();
                    break;
                case 17:
                    Maul maul = new Maul(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    maul.WeaponAddToInventory();
                    break;
                case 19:
                    MorningStar morningStar = new MorningStar(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    morningStar.WeaponAddToInventory();
                    break;
                case 20:
                    Sabre sabre = new Sabre(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    sabre.WeaponAddToInventory();
                    break;
                case 21:
                    Scimitar scimitar = new Scimitar(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    scimitar.WeaponAddToInventory();
                    break;
                case 22:
                    ShortSword shortSword = new ShortSword(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    shortSword.WeaponAddToInventory();
                    break;
                case 23:
                    SmallAxe smallAxe = new SmallAxe(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    smallAxe.WeaponAddToInventory();
                    break;
                case 24:
                    SpikedClub spikedClub = new SpikedClub(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    spikedClub.WeaponAddToInventory();
                    break;
                case 25:
                    TwoHandedSword twoHandedSword = new TwoHandedSword(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    twoHandedSword.WeaponAddToInventory();
                    break;
                case 26:
                    WarHammer warHammer = new WarHammer(prefixName, prefixStat, prefixValue, suffixName, suffixStat, suffixValue);
                    warHammer.WeaponAddToInventory();
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
