using System;
using System.Collections.Generic;
using System.Text;

namespace TrialByCombat.Weapons
{
    internal class LargeAxe : Weapon
    {
        public LargeAxe(string pName, string pStat, int pValue, string sName, string sStat, int sValue)
        {
            Type = "Weapon";
            Name = "Large Axe";
            Description = "a large axe";
            Slot = "Main Hand";
            Gold = 750;

            PrefixName = pName;
            PrefixStat = pStat;
            PrefixValue = pValue;
            SuffixName = sName;
            SuffixStat = sStat;
            SuffixValue = sValue;

            DamageLow = 6;
            DamageHigh = 16;
        }
    }
}