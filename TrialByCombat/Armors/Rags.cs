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
            ArmorClass = Roll(ArmorLow, ArmorHigh);
        }
    }
}