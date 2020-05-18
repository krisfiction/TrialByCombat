using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Armors
{
    internal class Rags : Armor
    {
        public Rags(string slot, string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Armor";
            Name = "Rags";
            Description = "tattered rags";
            Slot = slot;
            Gold = 5;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            ArmorLow = 2;
            ArmorHigh = 6;
            ArmorClass = Armor.ArmorRoll(ArmorLow, ArmorHigh);  //ArmorRoll();
        }

        //private int ArmorRoll()
        //{
        //    Random rand = new Random();
        //    return rand.Next(ArmorLow, ArmorHigh + 1);
        //}

        //public void AddToInventory()
        //{
        //    Inventory.Inventories.Add(new Inventory(Type, Name, Description, Slot, Gold, PrefixName, PrefixStat, PrefixValue, SuffixName, SuffixStat, SuffixValue, ArmorClass));
        //}
    }
}