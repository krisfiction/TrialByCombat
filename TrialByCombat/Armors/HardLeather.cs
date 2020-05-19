using System;

namespace TrialByCombat.Armors
{
    class HardLeather : Armor
    {
        public HardLeather(string slot, string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Armor";
            Name = "Hard Leather";
            Description = "hard leather armor";
            Slot = slot;
            Gold = 450;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            ArmorLow = 11;
            ArmorHigh = 14;
            ArmorClass = Roll(ArmorLow, ArmorHigh);
        }
    }
}
