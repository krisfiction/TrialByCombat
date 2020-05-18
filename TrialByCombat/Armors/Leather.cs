using System;

namespace TrialByCombat.Armors
{
   internal class Leather : Armor
    {
        public Leather(string slot, string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Armor";
            Name = "Leather";
            Description = "leather armor";
            Slot = slot;
            Gold = 300;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            ArmorLow = 10;
            ArmorHigh = 13;
            ArmorClass = Armor.ArmorRoll(ArmorLow, ArmorHigh);
        }
    }
}
