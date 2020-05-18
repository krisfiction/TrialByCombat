using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Armors
{
    internal class ChainMail : Armor
    {
        public ChainMail(string slot, string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Armor";
            Name = "Chain Mail";
            Description = "chain mail armor";
            Slot = slot;
            Gold = 1250;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            ArmorLow = 18;
            ArmorHigh = 22;
            ArmorClass = Armor.ArmorRoll(ArmorLow, ArmorHigh);
        }
    }
}