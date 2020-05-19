using System;

namespace TrialByCombat.Armors
{
    internal class RingMail : Armor
    {
        public RingMail(string slot, string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Armor";
            Name = "Ring Mail";
            Description = "ring mail armor";
            Slot = slot;
            Gold = 900;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            ArmorLow = 17;
            ArmorHigh = 20;
            ArmorClass = Roll(ArmorLow, ArmorHigh);
        }
    }
}
