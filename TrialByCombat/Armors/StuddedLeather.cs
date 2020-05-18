using System;

namespace TrialByCombat.Armors
{
    internal class StuddedLeather : Armor
    {
        public StuddedLeather(string slot, string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Armor";
            Name = "Studded Leather";
            Description = "studded leather armor";
            Slot = slot;
            Gold = 700;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            ArmorLow = 15;
            ArmorHigh = 17;
            ArmorClass = Armor.ArmorRoll(ArmorLow, ArmorHigh);
        }
    }
}
