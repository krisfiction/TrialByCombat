using System;

namespace TrialByCombat.Armors
{
    internal class Quilted : Armor
    {
        public Quilted(string slot, string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Armor";
            Name = "Quilted Armor";
            Description = "sewn cloth";
            Slot = slot;
            Gold = 200;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            ArmorLow = 7;
            ArmorHigh = 10;
            ArmorClass = Roll(ArmorLow, ArmorHigh);
        }
    }
}
